using Shamilova_ObrazPlus.Forms;
using System;
using System.Windows.Forms;
using Shamilova_ObrazPlus.Models;

namespace Shamilova_ObrazPlus
{
    internal static class Program
    {
        public static ObrazPlus_Db context = new ObrazPlus_Db();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Не удаётся установить связь с БД!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
