using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Krasnov_3
{
    public static class Messages
    {
        /// <summary>
        /// Режим вывода сообщения
        /// </summary>
        public enum ModePrint
        {
            Success,
            Error,
            Delete,
            CountError,
            IndexError,
            CoordError
        }

        /// <summary>
        /// Выводит пользователю сообщение
        /// </summary>
        /// <param name="mode">режим вывода сообщения</param>
        /// <param name="lst">список штабов</param>
        /// <param name="exception">иформация о возникшем исключении</param>
        public static void PrintMessBox(ModePrint mode, List<Headquarter> lst, Exception exception)
        {
            if (ModePrint.Success == mode)
                MessageBox.Show("Запись прошла успешно", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ModePrint.Error == mode)
                MessageBox.Show(exception.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (ModePrint.Delete == mode)
                MessageBox.Show("В ячейке были удалены вхождения символа \";\"", "Удаление",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (ModePrint.CountError == mode)
            {
                if (lst == null || lst.Count == 0)
                {
                    MessageBox.Show($"Необходимо загрузить csv-файл",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Необходимо ввести целое число > 1 и меньшее {lst.Count + 1}",
                        "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ModePrint.IndexError == mode)
            {
                if (lst == null)
                {
                    MessageBox.Show($"Необходимо загрузить csv-файл",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lst.Count == 1)
                {
                    MessageBox.Show($"Удаление невозможно, так как в таблице осталась только 1 строка.",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Необходимо ввести целое число > 0 и меньшее {lst.Count}",
                        "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (ModePrint.CoordError == mode)
            {
                MessageBox.Show($"Необходимо ввести x из [-180, 180], y из [-90, 90]. " +
                    $"Разделителем является запятая.",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Перегруженный метод вывода сообщения пользователю
        /// </summary>
        /// <param name="mode">режим вывода сообщения</param>
        /// <param name="lst">список штабов</param>
        public static void PrintMessBox(ModePrint mode, List<Headquarter> lst) => PrintMessBox(mode, lst, null);
        
        /// <summary>
        /// Перегруженный метод вывода сообщения пользователю
        /// </summary>
        /// <param name="mode">режим вывода сообщения</param>
        /// <param name="ex"></param>
        public static void PrintMessBox(ModePrint mode, Exception ex) => PrintMessBox(mode, null, ex);
        
        /// <summary>
        /// Перегруженный метод вывода сообщения пользователю
        /// </summary>
        /// <param name="mode">режим вывода сообщения</param>
        public static void PrintMessBox(ModePrint mode) => PrintMessBox(mode, null, null);       
    }
}
