using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    static class InfoTracker
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InfoCardsForm());
        }
    }
}
