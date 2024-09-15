using AutoSclad.MasterSclad;
using AutoSclad.ServiceDialog;
using AutoSclad.Workman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSclad
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
            Application.Run(new AuthForm());
       /*     Application.Run(new MainForm());*/
        }
    }
}
