using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krasnov_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int indexDistr = 2;
        DataGridView dataGrid = new DataGridView();
        DataTable dt = new DataTable();
        List<Headquarter> lstHeadquarters = new List<Headquarter>();
        List<Headquarter> lstActiveHeads = new List<Headquarter>();
        List<string> districtsItemsCombo = new List<string>();

        /// <summary>
        /// Режим записи в csv-файл.
        /// </summary>
        enum ModeWriteToCsv
        {
            New,
            Edit
        }
        enum ModePrintMessage
        {
            Success,
            Error,
            Delete
        }
        /// <summary>
        /// Загрузить csv файл в datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "CSV|*.csv|TXT|*.txt",
                    ValidateNames = true,
                    Title = "Открытие файла"

                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // для обновления всех строк в таблице после каждого нажатия на кнопку
                        LocationClass.listCoord.Clear();
                        dt = new DataTable();
                        lstHeadquarters = new List<Headquarter>();
                        DataRow row;
                        string[] Lines = File.ReadAllLines(ofd.FileName, Encoding.GetEncoding(1251));
                        string[] Fields;
                        Fields = Lines[0].Split(new char[] { ';' });

                        // считываем названия столбцов
                        for (int i = 1; i < Fields.GetLength(0); i++)
                        {
                            // чтобы не учитывать последний пустой столбец
                            if (i < 10)
                            {
                                dt.Columns.Add(Fields[i]);
                            }
                        }


                        // считываем все строки, кроме первой, так как в ней находятся названия столбцов
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ';' });
                            row = dt.NewRow();
                            for (int j = 1; j < Fields.GetLength(0); j++)
                            {
                                if (j < 10)
                                {
                                    // избавляемся от ненужных при отображении в datagridview кавычек ""
                                    if (Fields[j] == "")
                                        row[j - 1] = null; // (j - 1) потому что начинаем считывать поля не с первого символа, 
                                                           //но в datatable нужно записывать с первого столбца, индекс которого 0
                                    else if (Fields[j].Contains("\""))
                                    {
                                        Fields[j] = Fields[j].Replace("\"", "");
                                        row[j - 1] = Fields[j];
                                    }
                                    else
                                        row[j - 1] = Fields[j];
                                }
                            }
                            lstHeadquarters.Add(new Headquarter(Fields));
                            lstActiveHeads.Add(lstHeadquarters[i - 1]);
                            dt.Rows.Add(row);
                            dataGridView.DataSource = dt;
                        }
                        SetItemsComboBox();
                        //MessageBox.Show($"Columns: {dt.Columns.Count} Rows: {dt.Rows.Count} Info: {dt.Rows[1].ItemArray[0]}");
                    }
                }
                //MessageBox.Show(lstHeadquarters.Count.ToString() + " " + lstHeadquarters[lstHeadquarters.Count - 1]);
            }
            catch (Exception ex) { PrintMessageBox(ModePrintMessage.Error, ex); }
        }

        /// <summary> 
        /// Устанавливает значения элементов comboBox.
        /// Отслеживает соответствие размеров списка штабов lstActiveHeads
        /// и таблицы dt.
        /// </summary>
        private void SetItemsComboBox()
        {
            if (dt.Rows.Count != lstActiveHeads.Count)
            {
                lstActiveHeads.Clear();
                LocationClass.listCoord.Clear();
                string[] tempArr = new string[dt.Columns.Count + 2];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tempArr[0] = (dt.Rows.Count + i).ToString();
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i].ItemArray[j] == null)
                            tempArr[j + 1] = string.Empty;
                        else
                            tempArr[j + 1] = dt.Rows[i].ItemArray[j].ToString();
                    }
                    tempArr[dt.Columns.Count + 1] = null;
                    lstActiveHeads.Add(new Headquarter(tempArr));
                    lstHeadquarters.Add(lstActiveHeads[lstActiveHeads.Count - 1]);
                    /*lstActiveHeads.Add(new Headquarter((dt.Rows.Count + i).ToString(),
                    Array.ConvertAll(dt.Rows[i].ItemArray, y => y.ToString()), null));*/
                }
                //MessageBox.Show("Success");
            }
            comboBox.Items.Clear();
            districtsItemsCombo.Clear();
            foreach (var head in lstActiveHeads)
            {
                if (!districtsItemsCombo.Contains(head.GeoLocation.District))
                    districtsItemsCombo.Add(head.GeoLocation.District);
            }
            comboBox.Items.AddRange(districtsItemsCombo.ToArray());
            comboBox.SelectedItem = comboBox.Items[0];
            // заодно меняем label о количестве строк в таблице
            lblCountRows.Text = dt.Rows.Count.ToString();
        }

        /// <summary>
        /// Сохранение в csv/txt формате.
        /// </summary>
        /// <param name="fileName"></param>
        private void WriteToCsv(string fileName, ModeWriteToCsv mode)
        {
            StringBuilder strBuild = new StringBuilder();

            // считываем названия столбцов при помощи расширений интерфейса и linq-запроса
            // в случае выбора режима создания нового файла при записи
            if (mode == ModeWriteToCsv.New)
            {
                IEnumerable<string> columnNames =
                    dt.Columns.Cast<DataColumn>().Select(column =>
                    {
                        if (column.ColumnName.Contains(";"))
                        {
                            PrintMessageBox(ModePrintMessage.Delete, null);
                            return column.ColumnName.Replace(";", "");
                        }
                        return column.ColumnName;
                    });

                strBuild.AppendLine("ROWNUM;" + string.Join(";", columnNames) + ";");
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // считываем элементы строки
                IEnumerable<string> fields =
                    dt.Rows[i].ItemArray.Select(field =>
                    {
                        if (field.ToString().Contains(";"))
                        {
                            PrintMessageBox(ModePrintMessage.Delete, null);
                            return "\"" + field.ToString().Replace(";", "") + "\"";
                        }
                        return "\"" + field.ToString() + "\"";
                    });

                strBuild.AppendLine($"{i + 1};" + string.Join(";", fields) + ";");
            }

            if (mode == ModeWriteToCsv.New)
            {
                // создаем новый файл и записываем (названия столбцов учитываются)
                File.WriteAllText($"{fileName}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                File.WriteAllText($"{fileName}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
            }
            else
            {
                // получаем имя файла, в который будет записана информация
                string name = string.Empty;
                int lengthName = fileName.Split('.').Length;
                if (lengthName >= 2)
                {
                    for (int i = 0; i < lengthName - 1; i++)
                    {
                        if (i < lengthName - 2)
                        {
                            name += fileName.Split('.')[i] + ".";
                        }
                        else
                        {
                            name += fileName.Split('.')[i];
                        }
                    }
                }
                else
                {
                    name = fileName;
                }
                // дозаписываем в существующие файлы (названия столбцов повторно не записываются)
                File.AppendAllText($"{name}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                File.AppendAllText($"{name}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));

            }
        }

        /// <summary>
        /// Записывает содержимое таблицы из datagridview в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                Title = "Запись в новый файл"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WriteToCsv(sfd.FileName, ModeWriteToCsv.New);
                        PrintMessageBox(ModePrintMessage.Success, null);
                    }
                    catch (Exception ex) { PrintMessageBox(ModePrintMessage.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Дозаписывает содержимое таблицы из datagridview в существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv|ALL FILES|*.*",
                ValidateNames = true,
                CheckFileExists = true,
                Title = "Запись в существующий файл"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WriteToCsv(sfd.FileName, ModeWriteToCsv.Edit);
                        PrintMessageBox(ModePrintMessage.Success, null);
                    }
                    catch (Exception ex) { PrintMessageBox(ModePrintMessage.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Удаляет нулевую строку в datagridview. TODO: номер строки, введенный пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteStr_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 1)
            {
                lstActiveHeads.RemoveAt(0);
                dt.Rows.RemoveAt(0);
                dataGrid.DataSource = dt;
                SetItemsComboBox();
            }
        }

        /// <summary>
        /// Показывает первые N столбцов. TODO: Число N вводится пользователем через textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            const int n = 10;
            const int countFieldsInHeadquarter = 10;
            DataRow row;

            // проверка числа на корректность (положительное число не должно превышать 
            // количество элементов в списке)
            if (n >= 1 && n <= lstHeadquarters.Count)
            {
                dt.Clear();
                lstActiveHeads.Clear();
                dataGrid.DataSource = dt;
                for (int i = 0; i < n; i++)
                {
                    row = dt.NewRow();
                    for (int j = 1; j < countFieldsInHeadquarter; j++)
                    {
                        // (j-1), так как индекс в таблице начинается с 0, но мы не должны учитывать ROWNUM
                        row[j - 1] = lstHeadquarters[i][j];
                    }
                    lstActiveHeads.Add(lstHeadquarters[i]);
                    dt.Rows.Add(row);
                }
                dataGrid.DataSource = dt;
                SetItemsComboBox();
            }
        }

        private void PrintMessageBox(ModePrintMessage mode, Exception exception)
        {
            if (ModePrintMessage.Success == mode)
                MessageBox.Show("Запись прошла успешно", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ModePrintMessage.Error == mode)
                MessageBox.Show(exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ModePrintMessage.Delete == mode)
                MessageBox.Show("В ячейке были удалены вхождения символа \";\"", "Удаление",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Возвращает наборы координат (x, y), принадлежащих одному району.
        /// Индекс района берется из comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetCoordOneDistrict_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex >= 0)
            {
                List<Coordinates> coords =
                    LocationClass.GetCoodinatesFromOneArea(dt.Rows[comboBox.SelectedIndex].ItemArray[indexDistr].ToString());
                var arr = coords.ToArray();
                //MessageBox.Show(arr.Length.ToString());
                if (coords.Count > 0)
                {
                    string[] res = new string[coords.Count + 1];
                    res[0] = $"{coords[0].District} ";
                    for (int i = 0; i < coords.Count; i++)
                    {
                        res[i + 1] = $"X:{coords[i].X_WGS} Y:{coords[i].Y_WGS}\n";
                    }
                    textBoxCoord.Lines = res;
                }
            }
        }

        /// <summary>
        /// Фиксируются изменения, происходящие при добавлении пользователем строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            lblCountRows.Text = $"{dt.Rows.Count + 1}";

        }

        /// <summary>
        /// Фиксируются изменения, происходящие при удалении пользователем строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            lblCountRows.Text = $"{dt.Rows.Count}";
            MessageBox.Show(e.Row.Index.ToString());
            lstHeadquarters.RemoveAll(field => field.GeoLocation.District == e.Row.Cells[indexDistr].Value.ToString());
            SetItemsComboBox();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGetCoordOneDistrict_Click(sender, e);
        }
    }
}
