﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Deneme1
{
    static class Program
    {
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDeneme());
            
        }
    }
}
