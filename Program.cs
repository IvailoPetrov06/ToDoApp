﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Controller;

namespace ToDoApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// </summary>
       ///ss
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserController userController = new UserController();

       
            LoginForm loginForm = new LoginForm(userController);
            Application.Run(loginForm);
        }
    }
}
