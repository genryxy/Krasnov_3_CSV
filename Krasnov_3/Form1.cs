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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        /*var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                        using (var csvReader = new CsvReader(sr))
                        {
                            while (csvReader.Read())
                                headquarterBindingSource.DataSource = csvReader.GetRecord<Headquarter>().ToString();
                        }*/
                        string[] Lines = File.ReadAllLines(ofd.FileName);
                        string[] Fields;
                        Fields = Lines[0].Split(new char[] { ';' });
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
                            {
                                row[j] = Fields[j];
                            }
                            lstHeadquarters.Add(new Headquarter(Fields));
                            dt.Rows.Add(row);
                        }
                        dataGridView.DataSource = dt;
                    }
                }
                MessageBox.Show(lstHeadquarters.Count.ToString() + " " + lstHeadquarters[lstHeadquarters.Count-1]);
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
                    try
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
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            /*
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    using (var csvReader = new CsvReader(sr))
                    {
                        while (csvReader.Read())
                            headquarterBindingSource.DataSource = csvReader.GetRecord<Headquarter>().ToString();
                    }
                }
            }*/
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
