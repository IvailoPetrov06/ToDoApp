﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    internal static class Program
    {
        /// Ivailo ako chetesh tova znachi rabotish po proekta... BRAVO
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO
            Application.Run(new Form1());
        }
    }
}
