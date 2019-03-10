using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krasnov_3
{
    public static class Methods
    {

        /// <summary>
        /// Режим записи в csv-файл.
        /// </summary>
        public enum ModeWrite
        {
            New,
            Edit,
            Overwrite
        }

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

        /// <summary>
        /// Возвращает ближайший к пользователю штаб на основе введенных
        /// координат.
        /// </summary>
        /// <param name="coordX">координата X</param>
        /// <param name="coordY">координата  Y</param>
        /// <param name="lstActiveHeads">список отображаемых штабов</param>
        /// <returns></returns>
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
            return lstActiveHeads[indexRow].ToString();
        }

        /// <summary>
        /// Сохранение в csv/txt формате.
        /// </summary>
        /// <param name="fileName">имя сохраняемого файла</param>
        /// <param name="mode">режим записи</param>
        /// <param name="dt">таблица из DataGridView</param>
        public static void WriteToCsv(string fileName, ModeWrite mode, DataTable dt)
        {
            StringBuilder strBuild = new StringBuilder();

            // считываем названия столбцов при помощи расширений интерфейса и linq-запроса
            // в случае выбора режима New или Rewrite
            if (mode == ModeWrite.New || mode == ModeWrite.Overwrite)
            {
                IEnumerable<string> columnNames =
                    dt.Columns.Cast<DataColumn>().Select(column =>
                    {
                        if (column.ColumnName.Contains(";"))
                        {
                            Messages.PrintMessBox(Messages.ModePrint.Delete);
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
                            Messages.PrintMessBox(Messages.ModePrint.Delete);
                            return "\"" + field.ToString().Replace(";", "") + "\"";
                        }
                        return "\"" + field.ToString() + "\"";
                    });
                strBuild.AppendLine($"{i + 1};" + string.Join(";", fields) + ";");
            }

            if (mode == ModeWrite.New)
            {
                // создаем новый файл и записываем (названия столбцов учитываются)
                File.WriteAllText($"{fileName}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                File.WriteAllText($"{fileName}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
            }
            else
            {
                // получаем имя файла, в который будет записана информация
                string name = Methods.GetExistingName(fileName);
                if (ModeWrite.Edit == mode)
                {
                    // дозаписываем в существующие файлы (названия столбцов повторно не записываются)
                    File.AppendAllText($"{name}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                    File.AppendAllText($"{name}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
                }
                if (ModeWrite.Overwrite == mode)
                {
                    // дозаписываем в существующие файлы (названия столбцов повторно не записываются)
                    File.WriteAllText($"{name}.txt", strBuild.ToString(), Encoding.GetEncoding(1251));
                    File.WriteAllText($"{name}.csv", strBuild.ToString(), Encoding.GetEncoding(1251));
                }
            }
        }
    }
}
