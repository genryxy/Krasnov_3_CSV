using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        /// Возвращает ближайший к пользователю штаб на основе индекса выбранного штаба.
        /// </summary>
        /// <param name="indexSelectedHead">индекс выбранного штаба</param>
        /// <param name="lstActiveHeads">список отображаемых штабов</param>
        /// <returns></returns>
        public static string GetNearHead(int indexSelectedHead, List<Headquarter> lstActiveHeads)
        {
            int indexRow = 0;
            double x = 0, y = 0, curX = 0, curY = 0;
            double minDistance = double.MaxValue;

            if (CheckDoubleNumber(lstActiveHeads, indexSelectedHead, ref x, ref y))
            {
                for (int i = 0; i < lstActiveHeads.Count; i++)
                {
                    if (CheckDoubleNumber(lstActiveHeads, i, ref curX, ref curY)
                        && curX != x && curY != y)
                    {
                        double temp = Math.Sqrt(Math.Pow(x - curX, 2) + Math.Pow(y - curY, 2));
                        if (minDistance > temp)
                        {
                            minDistance = temp;
                            indexRow = i;
                        }
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

        /// <summary>
        /// Проверяет значение TextBox на принадлежность типу double.
        /// </summary>
        /// <param name="lstActiveHeads">Список активных штабов</param>
        /// <param name="indexSelectedHead">индекс выбранного штаба</param>
        /// <param name="x">координата х</param>
        /// <param name="y">координата y</param>
        /// <returns></returns>
        private static bool CheckDoubleNumber(List<Headquarter> lstActiveHeads, int indexSelectedHead, ref double x, ref double y)
        {
            return double.TryParse(lstActiveHeads[indexSelectedHead].GeoLocation.X_WGS,
                NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out x) && 
                double.TryParse(lstActiveHeads[indexSelectedHead].GeoLocation.Y_WGS,
                NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out y);
        }
    }
}
