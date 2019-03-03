using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krasnov_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataGridView dataGrid = new DataGridView();
        DataTable dt = new DataTable();
        List<Headquarter> lstHeadquarters = new List<Headquarter>();

        /// <summary>
        /// Загрузить csv файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv|TXT|*.txt", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // чтобы каждый раз все строки в таблице обновлялись
                        dt = new DataTable();
                        lstHeadquarters = new List<Headquarter>();
                        string[] Lines = File.ReadAllLines(ofd.FileName, Encoding.Unicode);
                        string[] Fields;
                        Fields = Lines[0].Split(new char[] { ';' });
                        DataRow row;

                        // -1 для того чтобы не появлялся в конце пустой столбец
                        //1st row must be column names; force lower case to ensure matching later on.
                        for (int i = 0; i < Fields.GetLength(0); i++)
                        {
                            dt.Columns.Add(Fields[i]);
                            /*if (i == 0)
                                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                            else if (i >= 7 && i <= 9)
                                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                            else
                                dt.Columns.Add(Fields[i].ToLower());*/
                        }

                        // считываем все строки, кроме первой
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ';' });
                            row = dt.NewRow();
                            for (int j = 0; j < Fields.GetLength(0); j++)
                            {
                                /*if (j >= 7 && j <= 9)
                                {
                                    if (Fields[j] == "")
                                        row[j] = -1;
                                    else if (Fields[j].Contains("\""))
                                    {
                                        string number = Fields[j].Replace("\"", "");
                                        if (number.Contains("."))
                                            row[j] = double.Parse(number.Replace(".", ","));
                                        else
                                            row[j] = double.Parse(number);
                                    }  
                                    else
                                        row[j] = double.Parse(Fields[j]);
                                }
                                else*/

                                // избавляемся от ненужных кавычек ""
                                if (Fields[j] == "")
                                    row[j] = null;
                                else if (Fields[j].Contains("\""))
                                {
                                    Fields[j] = Fields[j].Replace("\"", "");
                                    row[j] = Fields[j];
                                }
                                else
                                    row[j] = Fields[j];
                            }
                            lstHeadquarters.Add(new Headquarter(Fields));
                            dt.Rows.Add(row);
                        }
                        dataGridView.DataSource = dt;
                    }
                }
                //MessageBox.Show(lstHeadquarters.Count.ToString() + " " + lstHeadquarters[lstHeadquarters.Count - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение в csv/txt
        /// </summary>
        /// <param name="fileName"></param>
        public void WriteToCsv(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            // считываем названия столбцов при помощи расширений интерфейса и linq-запроса
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column =>
            {
                if (!column.ColumnName.Contains("Column1"))
                    return "\"" + column.ColumnName + "\"";
                return null;
            });
            sb.AppendLine(string.Join(";", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                // считываем элементы строки
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                {  
                    
                    return "\"" + field.ToString() + "\"";
                });

                sb.AppendLine(string.Join(";", fields));
            }
            // записываем в файл
            File.WriteAllText($"{fileName}.txt", sb.ToString(), Encoding.Unicode);
            File.WriteAllText($"{fileName}.csv", sb.ToString(), Encoding.Unicode);
        }

        /// <summary>
        /// Записывает содержимое таблицы в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|.*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WriteToCsv(sfd.FileName);
                        MessageBox.Show("Записали", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            if (dt.Rows.Count > 0)
            {
                lstHeadquarters.RemoveAt(0);
                dt.Rows.RemoveAt(0);
                dataGrid.DataSource = dt;
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

            if (n <= lstHeadquarters.Count && n >= 1)
            {
                dt.Clear();
                dataGrid.DataSource = dt;
                for (int i = 0; i < n; i++)
                {
                    row = dt.NewRow();
                    for (int j = 0; j < countFieldsInHeadquarter; j++)
                    {
                        //if (j == 0)
                        //   row[j] = int.Parse(lstHeadquarters[i][j]);
                        //else
                        row[j] = lstHeadquarters[i][j];
                    }
                    dt.Rows.Add(row);
                }
                dataGrid.DataSource = dt;
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            /*MessageBox.Show(dt.Rows.Count.ToString());
            lstHeadquarters = new List<Headquarter>();
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                lstHeadquarters.Add(new Headquarter(Array.ConvertAll(dt.Rows[i].ItemArray.ToArray(), y => y.ToString())));
            }
            MessageBox.Show(lstHeadquarters[0].ROWNUM.ToString());*/
        }
    }
}
