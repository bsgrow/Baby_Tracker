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
            babyNameRetrival();

        }

        private void newBaby_btn_Click(object sender, EventArgs e)
        {
            babyEntryForm.Show();
        }


        public void babyNameRetrival()
        {
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
        }

        private void babySelector_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem);
        }
    }
}
