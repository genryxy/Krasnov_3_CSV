﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Важно!
 * При добавлении новой строки в исходный список lstHeadquarters добавляется созданная 
 * строка. Но удаляется строка только из списка активных штабов lstActiveHeads (тех, что
 * выведены в таблице). Таким образом, всегда можно получить информацию о штабах 
 * изначально загруженных и добавленных. Изменения, внесенные пользователем, видны только
 * в таблице, то есть, если нажать на кнопку "Вывести нужное количество строк", то будут
 * выведены исходные строки с начальными значениями + добавленные строки.
 * */
namespace Krasnov_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        const int indexDistr = 2;

        bool checkChanges = false; // произошли ли изменения в таблице
        int countSelectedRows = 2;
        int indexDeleteRow = 0;
        double coordX, coordY;
        int countAddedRows = 0;

        DataGridView dataGrid = new DataGridView();
        DataTable dt = new DataTable();
        List<Headquarter> lstHeadquarters = new List<Headquarter>();
        List<Headquarter> lstActiveHeads = new List<Headquarter>();
        List<string> districtsItemsCombo = new List<string>();
        List<string> admAreaItemsCombo = new List<string>();

        /// <summary> 
        /// Устанавливает значения элементов comboBoxDistrict.
        /// </summary>
        private void SetItemsComboBoxDistrict()
        {
            Methods.CheckArraySize(dt, lstActiveHeads, ref checkChanges);
            toolComboBoxDistrict.Items.Clear();
            districtsItemsCombo.Clear();
            foreach (var head in lstActiveHeads)
            {
                districtsItemsCombo.Add(head.GeoLocation.District);
            }
            toolComboBoxDistrict.Items.AddRange(districtsItemsCombo.ToArray());
            // заодно меняем label о количестве строк в таблице
            lblCountRows.Text = dt.Rows.Count.ToString();
        }

        /// <summary>
        /// Удаляет строку с индексом N из datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteStr_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            if (!int.TryParse(textBoxIndexDeleteRow.Text, out indexDeleteRow)
               || indexDeleteRow < 1 || indexDeleteRow > lstActiveHeads.Count)
            {
                Messages.PrintMessBox(Messages.ModePrint.IndexError, lstActiveHeads);
                textBoxIndexDeleteRow.Focus();
            }
            else
            {
                if (dt.Rows.Count > 1)
                {
                    checkChanges = true;
                    // из первоначального списка ничего не удаляем
                    // если удалять, то нужно и сортировать
                    //lstHeadquarters.RemoveAt(indexDeleteRow - 1);
                    lstActiveHeads.RemoveAt(indexDeleteRow - 1);
                    dt.Rows.RemoveAt(indexDeleteRow - 1);
                    dataGrid.DataSource = dt;
                    SetItemsComboBoxDistrict();
                }
                else { Messages.PrintMessBox(Messages.ModePrint.IndexError, lstActiveHeads); }
            }
        }

        /// <summary>
        /// Показывает первые N столбцов. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            const int countFieldsInHeadquarter = 10;

            Methods.CheckArraySize(dt, lstActiveHeads, ref checkChanges);
            CheckUserAddedRows();

            // проверка числа на корректность (положительное число не должно превышать 
            // количество элементов в списке)
            if (!int.TryParse(textBoxCountSelectedRows.Text, out countSelectedRows)
                || countSelectedRows < 2 || countSelectedRows > lstHeadquarters.Count)
            {
                if ((countSelectedRows == 1) || (lstHeadquarters != null && lstHeadquarters.Count > 1))
                { Messages.PrintMessBox(Messages.ModePrint.CountError, lstHeadquarters); }
                else { Messages.PrintMessBox(Messages.ModePrint.CountError); }
                textBoxCountSelectedRows.Focus();
            }
            else
            {
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
        /// Фиксируются изменения, происходящие при добавлении пользователем строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            countAddedRows++;
            lblCountRows.Text = $"{dt.Rows.Count + 1}";
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
        /// Записывает содержимое таблицы из datagridview в новый файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
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
                        Methods.WriteToCsv(sfd.FileName, Methods.ModeWrite.New, dt);
                        Messages.PrintMessBox(Messages.ModePrint.Success);
                    }
                    catch (Exception ex) { Messages.PrintMessBox(Messages.ModePrint.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Дописывает содержимое таблицы из datagridview в существующий файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                CheckFileExists = true,
                OverwritePrompt = false,
                Title = "Запись в существующий файл"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Methods.WriteToCsv(sfd.FileName, Methods.ModeWrite.Edit, dt);
                        Messages.PrintMessBox(Messages.ModePrint.Success);
                    }
                    catch (Exception ex) { Messages.PrintMessBox(Messages.ModePrint.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Записывает содержимое таблицы из datagridview в существующий файл.
        /// Старые данные удаляются.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overwriteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                CheckFileExists = true,
                Title = "Изменение в существующем файле"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Methods.WriteToCsv(sfd.FileName, Methods.ModeWrite.Overwrite, dt);
                        Messages.PrintMessBox(Messages.ModePrint.Success);
                    }
                    catch (Exception ex) { Messages.PrintMessBox(Messages.ModePrint.Error, ex); }
                }
            }
        }

        /// <summary>
        /// Загрузить csv файл в datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBtnDownload_Click(object sender, EventArgs e)
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
                        toolComboBoxDistrict.SelectedItem = toolComboBoxDistrict.Items[0];
                        //MessageBox.Show($"Columns: {dt.Columns.Count} Rows: {dt.Rows.Count} Info: {dt.Rows[1].ItemArray[0]}");

                        // добавляем элементы в comboBox
                        toolComboBoxAdmArea.Items.Clear();
                        admAreaItemsCombo.Clear();
                        foreach (var head in lstActiveHeads)
                        {
                            if (!admAreaItemsCombo.Contains(head.GeoLocation.AdmArea))
                            { admAreaItemsCombo.Add(head.GeoLocation.AdmArea); }
                        }
                        toolComboBoxAdmArea.Items.AddRange(admAreaItemsCombo.ToArray());
                    }
                }
            }
            catch (Exception ex) { Messages.PrintMessBox(Messages.ModePrint.Error, ex); }
        }

        /// <summary>
        /// Обновляем предлагаемый список элементов перед открытием списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolComboBoxDistrict_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            SetItemsComboBoxDistrict();
        }

        /// <summary>
        /// Возвращает наборы координат (x, y), принадлежащих одному району.
        /// Индекс района берется из comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolComboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolComboBoxDistrict.SelectedIndex >= 0)
            {
                List<Coordinates> coords = LocationClass.GetCoodinatesFromOneArea(
                    dt.Rows[toolComboBoxDistrict.SelectedIndex].ItemArray[indexDistr].ToString());
                var arr = coords.ToArray();
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
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            if (lstActiveHeads.Count > 0)
            {
                List<string> lstName = new List<string>();
                for (int i = 0; i < lstActiveHeads.Count; i++)
                {
                    lstName.Add(lstActiveHeads[i].Name);
                }
                // сортирует только активные штабы
                lstActiveHeads = lstActiveHeads.OrderBy(x => x.Name).ToList();
                //lstHeadquarters = lstHeadquarters.OrderBy(x => x.Name).ToList();
                Methods.UpdateDataTable(dt, lstActiveHeads, dataGrid);
            }
            else { Messages.PrintMessBox(Messages.ModePrint.CountError); }
        }

        /// <summary>
        /// Сортировать по столбцу "AdmArea"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            if (lstActiveHeads.Count > 0)
            {
                List<string> lstAdmArea = new List<string>();
                for (int i = 0; i < lstActiveHeads.Count; i++)
                {
                    lstAdmArea.Add(lstActiveHeads[i].GeoLocation.AdmArea);
                }
                // сортирует только активные штабы
                lstActiveHeads = lstActiveHeads.OrderBy(x => x.GeoLocation.AdmArea).ToList();
                //lstHeadquarters = lstHeadquarters.OrderBy(x => x.GeoLocation.AdmArea).ToList();
                Methods.UpdateDataTable(dt, lstActiveHeads, dataGrid);
            }
            else { Messages.PrintMessBox(Messages.ModePrint.CountError); }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnDeleteStr, "If you click, the row with the entered index will be deleted.");
            toolTip.SetToolTip(btnShow, "If you click, the entered number of the rows will be shown.");
            toolTip.SetToolTip(btnGetNearHead, "If you click, you'll get the nearest head.");
            toolTip.SetToolTip(textBoxCoordX, "Please, enter X_WGS.");
            toolTip.SetToolTip(textBoxCoordY, "Please, enter Y_WGS.");
        }

        /// <summary>
        /// Выводит в таблицу строки, AdmArea которых соответствует выбранному
        /// элементу в comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolComboBoxAdmArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolComboBoxAdmArea.SelectedIndex >= 0)
            {
                // выводим в таблицу подходящие строки
                List<Headquarter> tempHeads = new List<Headquarter>();
                for (int i = 0; i < lstHeadquarters.Count; i++)
                {
                    if (lstHeadquarters[i].GeoLocation.AdmArea == toolComboBoxAdmArea.SelectedItem.ToString())
                        tempHeads.Add(lstHeadquarters[i]);
                }
                lstActiveHeads.Clear();
                lstActiveHeads = new List<Headquarter>(tempHeads);
                Methods.UpdateDataTable(dt, lstActiveHeads, dataGrid);
                // заодно меняем label о количестве строк в таблице
                lblCountRows.Text = dt.Rows.Count.ToString();
            }
        }

        private void toolComboBoxAdmArea_Click(object sender, EventArgs e)
        {
            // проверяем не добавил ли пользователь в таблицу новые строки
            Methods.CheckArraySize(dt, lstActiveHeads, ref checkChanges);
            CheckUserAddedRows();  
        }

        private void CheckUserAddedRows()
        {
            if (countAddedRows > 0 && lstActiveHeads != null && lstHeadquarters != null)
            {
                for (int i = lstActiveHeads.Count - countAddedRows; i < lstActiveHeads.Count; i++)
                {
                    lstHeadquarters.Add(lstActiveHeads[i]);
                    if (!admAreaItemsCombo.Contains(lstActiveHeads[i].GeoLocation.AdmArea))
                        admAreaItemsCombo.Add(lstActiveHeads[i].GeoLocation.AdmArea);
                }
                toolComboBoxAdmArea.Items.Clear();
                toolComboBoxAdmArea.Items.AddRange(admAreaItemsCombo.ToArray());
                countAddedRows = 0;
            }
        }

        /// <summary>
        /// Возвращает ближайший к пользователю штаб на основе
        /// координат, введенных пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetNearHead_Click(object sender, EventArgs e)
        {
            CheckUserAddedRows();
            Methods.CheckArraySize(dt, lstActiveHeads, ref checkChanges);
            if (!double.TryParse(textBoxCoordX.Text, out coordX) ||
                !double.TryParse(textBoxCoordY.Text, out coordY) ||
                coordX < -180 || coordY < -90 || coordY > 90 || coordX > 180)
            { Messages.PrintMessBox(Messages.ModePrint.CoordError); }
            else
            {
                textBoxCoord.Text = Methods.GetNearHead(coordX, coordY, lstActiveHeads);
                //MessageBox.Show($"{coordX:f3}, {coordY:f3}");
            }
        }
    }
}
