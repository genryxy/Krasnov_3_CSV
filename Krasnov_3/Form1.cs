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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string CSVFilePathName = @"D:\HSE\прога\кдз_2\Варианты\Вариант 3\mycsv.csv.csv";
                string[] Lines = File.ReadAllLines(CSVFilePathName);
                string[] Fields;
                Fields = Lines[0].Split(new char[] { ';' });
                DataTable dt = new DataTable();
                DataRow row;

                //1st row must be column names; force lower case to ensure matching later on.
                for (int i = 0; i < Fields.GetLength(0); i++)
                {
                    if (i == 0)
                        dt.Columns.Add(Fields[i].ToLower(), typeof(int));
                    else
                        dt.Columns.Add(Fields[i].ToLower());
                }

                for (int i = 1; i < Lines.GetLength(0); i++)
                {
                    Fields = Lines[i].Split(new char[] { ';' });
                    row = dt.NewRow();
                    for (int j = 0; j < Fields.GetLength(0); j++)
                        row[j] = Fields[j];
                    dt.Rows.Add(row);
                }
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
            }
        }




        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|.*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(Headquarter));
                        foreach (Headquarter hd in headquarterBindingSource.DataSource as List<Headquarter>)
                        {
                            writer.WriteRecord(hd);
                        }
                    }
                    MessageBox.Show("Записали", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|.*.csv|All files(*.*)|*.*", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr);
                    headquarterBindingSource.DataSource = csv.GetRecord<Headquarter>().ToString();
                }
            }
        }

        /*
         private void toCsv(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";
 
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine += string.Format("\"{0}\"\t", dGV.Rows[i].Cells[j].Value);
                stOutput += stLine + "\n";
            }
            Encoding utf16 = Encoding.UTF8;
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        } 
         */
    }
}
