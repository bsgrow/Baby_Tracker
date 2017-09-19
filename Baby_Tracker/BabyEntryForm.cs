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
using System.IO;

namespace Baby_Tracker
{
    public partial class BabyEntryForm : Form
    {
        AddUpdateDeleteBaby addUpdateBaby = new AddUpdateDeleteBaby();
        string connectionString = "Data Source = C:\\Program Files (x86)/Baby Tracker/BabyDatabase.sqlite; Version=3;";


        //String declarations
        public static string firstName = "";
        public static string middleName = "";
        public static string lastName = "";
        public static string dob = "";
        public static double weight;
        public static double length;
        public static double headCir;
        public static string imagePath = "";
        public static string result = "";


        public BabyEntryForm()
        {
            InitializeComponent();
            updateProfilePicCombo();
        }


        /*
         * Allows for the picture to be displayed in the picture box on the form. This 
         * uses the name from the profilePic_combo to select the correct image from the 
         * database.
         */
        private void profilePic_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT ImagePath FROM ProfileImages where ImageName = '" + profilePic_comb.GetItemText(profilePic_comb.SelectedItem) + "'";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = Convert.ToString(reader["ImagePath"]);
                if (result == "")
                {
                    //do nothing
                }
                else
                {
                    profilePictureBox.Image = Image.FromFile(result);
                }
            }
        }


        /*
         * Allows for the textbox data from the users input to be record into
         * the database. This calls the class Addbaby, which is where the 
         * application then converts and store information into the database
         * table "BabyList".
         * 
         * Also, a kill feature is enabled to complete closing the form.
         */
        private void addEntry_btn_Click(object sender, EventArgs e)
        {
            if (firstName_tbox.Text == "" | dob_tbox.Text == "" | weight_tbox.Text == "" | length_tbox.Text == "" | head_tbox.Text == "")
            {
                MessageBox.Show("Either First Name, DOB, Weight, Length, Head Circumfirence are blank. Must have an entry!!");
            }
            else
            {

                //Sets the textbox inputs to a string for accessablity throughout application
                firstName = firstName_tbox.Text;
                middleName = middleName_tbox.Text;
                lastName = lastName_tbox.Text;
                dob = dob_tbox.Text;
                weight = double.Parse(weight_tbox.Text);
                length = double.Parse(length_tbox.Text);
                headCir = double.Parse(head_tbox.Text);
                imagePath = result;

                addUpdateBaby.addBaby();  //calls the method to add baby information to data table
                this.Hide();
                emptyTextFields();
            }
        }


        /*
         * Upon click this will hide the for and not record any data that 
         * was entered by the user. To make sure that the textfields have
         * no data, the will be set to blank here.
         */
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            emptyTextFields();
            Hide();
        }


        /*
         * Allows for the textboxes to be set to empty after a users input or 
         * if the user presses cancel. This method is called from both cancel 
         * and add buttons found on the BabyEntryForm.
         */
        public void emptyTextFields()
        {

            firstName_tbox.Text = "";
            middleName_tbox.Text = "";
            lastName_tbox.Text = "";
            dob_tbox.Text = "";
            weight_tbox.Text = "";
            length_tbox.Text = "";
            head_tbox.Text = "";
            pathLocation_lb.Text = "";

        }


        /*
         * Calls the ProfileImages datatable to display the names of the images
         * that are associated with the database. These images are then displayed 
         * in the profilePic_comb box.
         */
        public void updateProfilePicCombo()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT ImageName FROM ProfileImages", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    profilePic_comb.DisplayMember = "ImageName";
                    profilePic_comb.DataSource = dt;
                    connection.Close();
                }
            }
        }
    }
}
