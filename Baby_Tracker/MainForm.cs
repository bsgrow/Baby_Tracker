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

        public BabyTracker()
        {
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
             using (SQLiteConnection connection = new SQLiteConnection(connectionString))
             {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    babySelector_cmbo.DisplayMember = "FirstName";
                    babySelector_cmbo.DataSource = null;
                    babySelector_cmbo.DataSource = dt;
                    babySelector_cmbo.ResetText();
                    connection.Close();
                }
             }
          }


        /*
        *  Used for the selection of the combobox name to be changed throughout the program
        *  as needed. Also, the image for each baby is changed here where the path is called
        *  from the database to then load the image for each baby based off of the selection
        *  from the combobox
        *  
        *  Note: The heart of changing data between differenet babies.
        */
        private void babySelector_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem); //loads the selected name from combobox to theis label

            string query = "SELECT BabyImagePath FROM BabyList where FirstName = '" + babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'";
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                {
                    string result = Convert.ToString(reader["BabyImagePath"]);
                    userImage_box.Image = Image.FromFile(result);
                }
        }  
        
    }
}
