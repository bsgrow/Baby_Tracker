using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Baby_Tracker
{
    public partial class BabyTracker : Form
    {
        BabyEntryForm babyEntryForm = new BabyEntryForm();
        DatabaseCreation dc = new DatabaseCreation();

        public BabyTracker()
        {
            dc.databaseCreation();
            InitializeComponent();
            comboBoxNameRetrival();

        }


        /*
        *  Allows for the BabyEntryForm to be opened for the user to 
        *  add a new entry for a baby.
        *
        *  Note: Main purpose is to show the form here and thats it
        */
        private void newBaby_btn_Click(object sender, EventArgs e)
        {
            babyEntryForm.Show();
        }


        /*
        *  Calls the FirstName table from the SQLite database to be displayed inside
        *  the combob box. This is also set to refresh as a new baby is entered into the
        *  application.
        */
        public void comboBoxNameRetrival()
        {

             string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
<<<<<<< HEAD
        
             using (SQLiteConnection connection = new SQLiteConnection(connectionString))
=======
             using (SQLiteConnection connection = new SQliteConnection(connectionString))
>>>>>>> 937dfb2f2ddb49e9fc52e83d494c002652028cd5
             {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
<<<<<<< HEAD
                    babySelector_cmbo.DisplayMember = "FirstName";
                    Console.WriteLine("This is going to the correct place");
                    babySelector_cmbo.DataSource = null;

                    babySelector_cmbo.DataSource = dt;
=======
                    babySelector_cmbo.Datasource = dt;
                    babySelector_cmbo.ResetText();
>>>>>>> 937dfb2f2ddb49e9fc52e83d494c002652028cd5
                    connection.Close();
                }
             }
        
        
        
            /* THis is the previous used database connection to update combobox
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string namesQuery = "SELECT * FROM BabyList";
            SQLiteCommand command = new SQLiteCommand(namesQuery, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                babySelector_cmbo.Items.Add(reader["FirstName"].ToString());
            }
            */
        }


        /*
        *  Method is allowing for the baby name that is selected from the combo box to be
        *  display or called to use throughout the application as needed. 
        */
        private void babySelector_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem);
        }
    }
}
