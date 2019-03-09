using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Krasnov_3
{
    public static class Methods
    {
        /// <summary>
        /// Возвращает имя существующего файла в нужном формате.
        /// </summary>
        /// <param name="fileName">исходное имя файла</param>
        /// <returns>корректное имя файла</returns>
        public static string GetExistingName(string fileName)
        {
            string name = string.Empty;
            int lengthName = fileName.Split('.').Length;
            if (lengthName >= 2)
            {
                for (int i = 0; i < lengthName - 1; i++)
                {
                    if (i < lengthName - 2)
                    { name += fileName.Split('.')[i] + "."; }
                    else
                    { name += fileName.Split('.')[i]; }
                }
            }
            else { name = fileName; }
            return name;
        }

        /// <summary>
        ///  Обновляет таблицу, которая выводится пользователю
        /// </summary>
        /// <param name="dt">таблица, отображаемая в DataGridView</param>
        /// <param name="lstActiveHeads">список активных штабов</param>
        /// <param name="dataGrid">экземпляр DataGridView</param>
        public static void UpdateDataTable(DataTable dt, List<Headquarter> lstActiveHeads, DataGridView dataGrid)
        {
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
        /// Отслеживает соответствие размеров списка штабов lstActiveHeads и таблицы dt.
        /// </summary>
        /// <param name="dt">таблица, отображаемая в DataGridView</param>
        /// <param name="lstActiveHeads">список активных штабов</param>
        /// <param name="checkChanges">наличие измененений, внесенных пользователем</param>
        public static void CheckArraySize(DataTable dt, List<Headquarter> lstActiveHeads, ref bool checkChanges)
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
                        { tempArr[j + 1] = string.Empty; }
                        else
                        { tempArr[j + 1] = dt.Rows[i].ItemArray[j].ToString(); }
                    }
                    tempArr[dt.Columns.Count + 1] = null;
                    lstActiveHeads.Add(new Headquarter(tempArr));
                }
                checkChanges = false;
            }
        }

        public static string GetNearHead(double coordX, double coordY, List<Headquarter> lstActiveHeads)
        {
            if (LocationClass.listCoord.Count == 0)
            {
                Messages.PrintMessBox(Messages.ModePrint.CountError);
                return null;
            }
            double x, y;
            double minDistance = double.MaxValue;
            int indexRow = 0;
            for (int i = 0; i < LocationClass.listCoord.Count; i++)
            {
                if (double.TryParse(LocationClass.listCoord[i].X_WGS.Replace(".",","), out x) &&
                    double.TryParse(LocationClass.listCoord[i].Y_WGS.Replace(".", ","), out y))
                {
                    double temp = Math.Sqrt(Math.Pow(x - coordX, 2) + Math.Pow(y - coordY, 2));
                    if (minDistance > temp)
                    {
                        minDistance = temp;
                        indexRow = i;
                    }
                }
            }
            //MessageBox.Show(double.TryParse(null, out minDistance).ToString());         
            return lstActiveHeads[indexRow].ToString();
        }
    }
}
