using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult dResult = DialogResult.OK;        //запуск формы регистрации раньше основной формы     
            using (Register frmLogining = new Register())
            {
                dResult = frmLogining.ShowDialog();
            }
            if (dResult == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
