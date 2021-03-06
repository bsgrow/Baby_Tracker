﻿using System;
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
    public partial class BabyUpdateForm : Form
    {

        AddUpdateDeleteBaby addUpdateBaby = new AddUpdateDeleteBaby();
        public static string result = "";
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";

        //String declarations
        public static string updateImagePath = "";
        public static string comboName = "";


        public BabyUpdateForm()
        {
            InitializeComponent();
            updateComboBox();
            profileCombobox();
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
        * Upon click this will hide the for and not record any data that 
        * was entered by the user. To make sure that the textfields have
        * no data, the will be set to blank here.
        */
        private void updateCancel_btn_Click(object sender, EventArgs e)
        {
            emptyTextFields();
            Hide();
        }


        /*
         * Allows for the textboxes to be set to empty after a users input or 
         * if the user presses cancel. This method is called from both cancel 
         * and add buttons found on the BabyUpdateForm.
         */
        public void emptyTextFields()
        {
            updatePathLocation_lb.Text = "";
        }


        /*
         * Calls the AddUpdateBaby to allow for the connection to update the 
         * certain fields that the user had updated. User does not have to update
         * every field. 
         */
        private void updateEntry_btn_Click(object sender, EventArgs e)
        {
            updateImagePath = result;
            addUpdateBaby.updateBaby();
            Hide();
            emptyTextFields();
        }

        /*
         *  Calls the FirstName table from the SQLite database to be displayed inside
         *  the combob box. This is also set to refresh as a new baby is entered into the
         *  application.
         */
        public void updateComboBox()
        {
            comboName = updateCombo.GetItemText(updateCombo.SelectedItem);

            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    updateCombo.DisplayMember = "FirstName";
                    updateCombo.DataSource = dt;
                    connection.Close();
                }
            }

        }


        /*
         * Allows for the profile picture combobox to be feeled based off of the 
         * image that are pre-defined in the program. Using this combobox allows
         * for the image box to be changed as the user changes the name in the
         * combobox.
         */
        public void profileCombobox()
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

    }//End of Class
}//End of Namespace


