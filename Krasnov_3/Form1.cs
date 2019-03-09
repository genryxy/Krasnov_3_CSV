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

        bool checkChanges = false;
        int countSelectedRows = 2;
        int indexDeleteRow = 0;
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
            Edit,
            Rewrite
        }
        /// <summary>
        /// Режим вывода сообщения
        /// </summary>
        enum ModePrintMessage
        {
            Success,
            Error,
            Delete,
            CountError,
            IndexError
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
                        SetItemsComboBoxDistrict();
                        comboBoxDistrict.SelectedItem = comboBoxDistrict.Items[0];
                        //MessageBox.Show($"Columns: {dt.Columns.Count} Rows: {dt.Rows.Count} Info: {dt.Rows[1].ItemArray[0]}");
                    }
                }
                //MessageBox.Show(lstHeadquarters.Count.ToString() + " " + lstHeadquarters[lstHeadquarters.Count - 1]);
            }
            catch (Exception ex) { PrintMessageBox(ModePrintMessage.Error, ex); }
        }

        /// <summary> 
        /// Устанавливает значения элементов comboBoxDistrict.
        /// </summary>
        private void SetItemsComboBoxDistrict()
        {
            CheckArraySize();
            comboBoxDistrict.Items.Clear();
            districtsItemsCombo.Clear();
            foreach (var head in lstActiveHeads)
            {
                districtsItemsCombo.Add(head.GeoLocation.District);
            }
            comboBoxDistrict.Items.AddRange(districtsItemsCombo.ToArray());
            // заодно меняем label о количестве строк в таблице
            lblCountRows.Text = dt.Rows.Count.ToString();
        }      

        /// <summary>
        /// Отслеживает соответствие размеров списка штабов lstActiveHeads и таблицы dt.
        /// </summary>
        private void CheckArraySize()
        {
            if (dt.Rows.Count != lstActiveHeads.Count || checkChanges)
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
                    /*lstActiveHeads.Add(new Headquarter((dt.Rows.Count + i).ToString(),
                    Array.ConvertAll(dt.Rows[i].ItemArray, y => y.ToString()), null));*/
                }
                //if (!checkChanges)
                //lstHeadquarters.Add(lstActiveHeads[lstActiveHeads.Count - 1]);
                checkChanges = false;
                //MessageBox.Show("Success");
            }
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
            if (mode == ModeWriteToCsv.New || mode == ModeWriteToCsv.Rewrite)
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
                if (ModeWriteToCsv.Edit == mode)
                {
                    // дозаписываем в существующие файлы (названия столбцов повторно не записываются)
                    File.AppendAllText($"{name}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                    File.AppendAllText($"{name}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
                }
                if (ModeWriteToCsv.Rewrite == mode)
                {
                    // дозаписываем в существующие файлы (названия столбцов повторно не записываются)
                    File.WriteAllText($"{name}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                    File.WriteAllText($"{name}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
                }

            }
        }

        /// <summary>
        /// Записывает содержимое таблицы из datagridview в новый файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                Title = "Запись в новый файл",
                OverwritePrompt = false
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
        /// Дописывает содержимое таблицы из datagridview в существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
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
        /// Записывает содержимое таблицы из datagridview в существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRewrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                CheckFileExists = true,
                Title = "Изменение в существующем файл"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WriteToCsv(sfd.FileName, ModeWriteToCsv.Rewrite);
                        PrintMessageBox(ModePrintMessage.Success, null);
                    }
                    catch (Exception ex) { PrintMessageBox(ModePrintMessage.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Удаляет строку с индексом N из datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteStr_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIndexDeleteRow.Text, out indexDeleteRow)
               || indexDeleteRow < 1 || indexDeleteRow > lstActiveHeads.Count)
            {
                PrintMessageBox(ModePrintMessage.IndexError, null);
                textBoxIndexDeleteRow.Focus();
            }
            else
            {
                if (dt.Rows.Count > 1)
                {
                    lstHeadquarters.RemoveAt(indexDeleteRow - 1);
                    lstActiveHeads.RemoveAt(indexDeleteRow - 1);
                    dt.Rows.RemoveAt(indexDeleteRow - 1);
                    dataGrid.DataSource = dt;
                    SetItemsComboBoxDistrict();
                }
                else
                {
                    PrintMessageBox(ModePrintMessage.IndexError, null);
                }
            }
        }

        /// <summary>
        /// Показывает первые N столбцов. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            // проверка числа на корректность (положительное число не должно превышать 
            // количество элементов в списке)
            if (!int.TryParse(textBoxCountSelectedRows.Text, out countSelectedRows)
                || countSelectedRows < 2 || countSelectedRows > lstHeadquarters.Count)
            {
                PrintMessageBox(ModePrintMessage.CountError, null);
                textBoxCountSelectedRows.Focus();
            }
            else
            {
                const int countFieldsInHeadquarter = 10;
                DataRow row;
                dt.Clear();
                lstActiveHeads.Clear();
                dataGrid.DataSource = dt;

                for (int i = 0; i < countSelectedRows; i++)
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
                SetItemsComboBoxDistrict();
            }
        }

        /// <summary>
        /// Выводит пользователю сообщение
        /// </summary>
        /// <param name="mode">режим вывода сообщения</param>
        /// <param name="exception">иформация о возникшем исключении</param>
        private void PrintMessageBox(ModePrintMessage mode, Exception exception)
        {
            if (ModePrintMessage.Success == mode)
                MessageBox.Show("Запись прошла успешно", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ModePrintMessage.Error == mode)
                MessageBox.Show(exception.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (ModePrintMessage.Delete == mode)
                MessageBox.Show("В ячейке были удалены вхождения символа \";\"", "Удаление",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (ModePrintMessage.CountError == mode)
            {
                if (lstHeadquarters.Count == 0)
                {
                    MessageBox.Show($"Необходимо загрузить csv-файл",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Необходимо ввести целое число > 1 и меньшее {lstHeadquarters.Count + 1}",
                        "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ModePrintMessage.IndexError == mode)
            {
                if (lstActiveHeads.Count == 0)
                {
                    MessageBox.Show($"Необходимо загрузить csv-файл",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lstActiveHeads.Count == 1)
                {
                    MessageBox.Show($"Удаление невозможно, так как в таблице осталась только 1 строка.",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Необходимо ввести целое число > 0 и меньшее {lstActiveHeads.Count}",
                        "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            lstActiveHeads.RemoveAll(field => field.GeoLocation.District == e.Row.Cells[indexDistr].Value.ToString());
            SetItemsComboBoxDistrict();
        }

        /// <summary>
        /// Позволяет следить за изменениями в ячейках
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            checkChanges = true;
        }
               
        /// <summary>
        /// Обновляем предлагаемый список элементов перед открытием списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDistrict_MouseClick(object sender, MouseEventArgs e)
        {
            SetItemsComboBoxDistrict();
        }

        /// <summary>
        /// Возвращает наборы координат (x, y), принадлежащих одному району.
        /// Индекс района берется из comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistrict.SelectedIndex >= 0)
            {
                List<Coordinates> coords =
                    LocationClass.GetCoodinatesFromOneArea(dt.Rows[comboBoxDistrict.SelectedIndex].ItemArray[indexDistr].ToString());
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
        /// Сортировать по столбцу "Name"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortedName_Click(object sender, EventArgs e)
        {
            List<string> lstName = new List<string>();
            for (int i = 0; i < lstActiveHeads.Count; i++)
            {                
                lstName.Add(lstActiveHeads[i].Name);
            }
            lstActiveHeads = lstActiveHeads.OrderBy(x => x.Name).ToList();
            //lstHeadquarters = lstHeadquarters.OrderBy(x => x.Name).ToList();
            lstHeadquarters.Clear();
            lstHeadquarters = new List<Headquarter>(lstActiveHeads);
            dt.Rows.Clear();

            DataRow row;
            for (int i = 0; i < lstActiveHeads.Count; i++)
            {
                row = dt.NewRow();
                for (int j = 1; j < row.ItemArray.Length + 1; j++)
                {
                    // (j-1), так как индекс в таблице начинается с 0, но мы не должны учитывать ROWNUM
                    row[j - 1] = lstActiveHeads[i][j];
                }
                dt.Rows.Add(row);
            }
            dataGrid.DataSource = dt;
        }

        /// <summary>
        /// Сортировать по столбцу "AdmArea"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortedAdmArea_Click(object sender, EventArgs e)
        {
            List<string> lstAdmArea = new List<string>();
            for (int i = 0; i < lstActiveHeads.Count; i++)
            {
                lstAdmArea.Add(lstActiveHeads[i].GeoLocation.AdmArea);
            }
            lstActiveHeads = lstActiveHeads.OrderBy(x => x.GeoLocation.AdmArea).ToList();
            lstHeadquarters.Clear();
            lstHeadquarters = new List<Headquarter>(lstActiveHeads);
            //lstHeadquarters = lstHeadquarters.OrderBy(x => x.GeoLocation.AdmArea).ToList();
            dt.Rows.Clear();

            DataRow row;
            for (int i = 0; i < lstActiveHeads.Count; i++)
            {
                row = dt.NewRow();
                for (int j = 1; j < row.ItemArray.Length + 1; j++)
                {
                    // (j-1), так как индекс в таблице начинается с 0, но мы не должны учитывать ROWNUM
                    row[j - 1] = lstActiveHeads[i][j];
                }
                dt.Rows.Add(row);
            }
            dataGrid.DataSource = dt;

        }
    }
}
