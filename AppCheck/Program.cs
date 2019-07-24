using AppChecker;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace AppCheck
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
        }
    }
}
