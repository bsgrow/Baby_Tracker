using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    public partial class BabyDeleteForm : Form
    {
        AddUpdateDeleteBaby addUpdateDeleteBaby = new AddUpdateDeleteBaby();
        public static string comboName = "";
        string connectionString = "Data Source = C:\\Program Files (x86)/Baby Tracker/BabyDatabase.sqlite; Version=3;";


        public BabyDeleteForm()
        {
            InitializeComponent();
            updateDeleteCombo();
        }


        /* 
         * Allows for the delete form to be hidden. 
         */
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }


        /*
         * Adds the names to the combobox found within the delete form
         * window. These names are called from the BabyList table where
         * only the first name of each baby is displayed
         */
        public void updateDeleteCombo()
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    deleteBaby_cmbo.DisplayMember = "FirstName";
                    deleteBaby_cmbo.DataSource = dt;
                    connection.Close();
                }
            }
        }


        /*
         * Retrieves the selected name found in the combobox.
         */
        private void deleteBaby_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboName = deleteBaby_cmbo.GetItemText(deleteBaby_cmbo.SelectedItem);
        }


        /*
         * Calls the delete baby method which then allows for the connection
         * to the database and to delete that row assicated with the baby,
         */
        private void deleteBaby_btn_Click(object sender, EventArgs e)
        {
            addUpdateDeleteBaby.deletebaby();
            Hide();
        }
    }
}
