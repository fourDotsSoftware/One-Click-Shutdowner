﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OneClickShutdowner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SystemStateMananger.Sleep();
        }        
    }
}