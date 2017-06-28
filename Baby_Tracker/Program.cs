using System;
using System.Collections.Generic;
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
            if (!File.Exists("BabyDatabase.sqlite")) 
            {
                DatabaseCreation database = new DatabaseCreation();
                database.databaseCreation();
            } else {
                //Do nothing
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BabyTracker());
     
        }
        
    }
}
