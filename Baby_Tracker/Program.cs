﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //checks for existing database, none found then created
            if (!File.Exists("C:\\Program Files (x86)/Baby Tracker/BabyDatabase.sqlite"))
            {
                DatabaseCreation database = new DatabaseCreation();
                database.databaseCreation();

            }
            else
            {
                Console.WriteLine("Data already created");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BabyTracker());

        }

    }
}
