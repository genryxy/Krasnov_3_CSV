using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Krasnov_3
{
    public static class Messages
    {
        private static string uploadFile = "You need to download CSV-file";
        private static string intNumber = "You need a positive integer >= 0 and <";
        private static string oneString = "You have only one string. ";

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
            ShowError
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
            { MessageBox.Show("Successful record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            if (ModePrint.Error == mode)
            { MessageBox.Show(exception.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (ModePrint.Delete == mode)
            {
                MessageBox.Show("Symbol occurrences of \";\" have been deleted in the cell ", "Warning!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ModePrint.CountError == mode)
            {
                if (lst == null || lst.Count == 0)
                { MessageBox.Show(uploadFile, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (lst.Count == 1)
                { MessageBox.Show(oneString + uploadFile,  "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                { MessageBox.Show($"{intNumber} {lst.Count}", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }

            if (ModePrint.ShowError == mode)
            {
                if (lst == null || lst.Count == 0)
                { MessageBox.Show(uploadFile, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (lst.Count == 1)
                { MessageBox.Show(oneString + uploadFile, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                { MessageBox.Show($"{intNumber} {lst.Count}", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }

            if (ModePrint.IndexError == mode)
            {
                if (lst == null || lst.Count == 0)
                { MessageBox.Show(uploadFile, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (lst.Count == 1)
                { MessageBox.Show($"{oneString} Removal is impossible", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                { MessageBox.Show($"{intNumber} {lst.Count}", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
