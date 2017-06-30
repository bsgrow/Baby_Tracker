using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    class AddUpdateBaby 
    {
        //String declarations
        public string path;
        public string targetPath;


        /*
         * Method is using the data from the BabyEntryForm textboxes to create a new row for
         * each new baby entered. The connection and all database requires are set up here. 
         * BabyList is the table that is being used for the storage of the information.
         */
        public void addBabyConnection()
        {
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = "INSERT INTO BabyList (ID, FirstName, MiddleName, LastName, DOB, BirthWeight, BirthLength, BirthHeadCir, BabyImagePath) VALUES (@id, @firstName, @middleName, @lastName, @DOB, @birthWeight, @birthLength, @birthHeadCir, @babyImagePath)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@firstName", BabyEntryForm.firstName);
                command.Parameters.AddWithValue("@middleName", BabyEntryForm.middleName);
                command.Parameters.AddWithValue("@lastName", BabyEntryForm.lastName);
                command.Parameters.AddWithValue("@DOB", BabyEntryForm.dob);
                command.Parameters.AddWithValue("@birthWeight", BabyEntryForm.weight);
                command.Parameters.AddWithValue("@birthLength", BabyEntryForm.length);
                command.Parameters.AddWithValue("@birthHeadCir", BabyEntryForm.headCir);
                command.Parameters.AddWithValue("@babyImagePath", BabyEntryForm.imagePath);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }


        /* Allows for a image to be selected for the baby entry. This is called via
         * both new baby entry and also update baby entry. Only JPEG na dPNG images 
         * are accepted here. The files are then saved to a folder (BabyImages) in
         * the application.
         */
        public void babyImagePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Selet Baby Profile Image";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = @"C:\Users\Brandon\Documents\Visual Studio 2017\Projects\Baby_Tracker\Baby_Tracker\BabyImages"; //save to file location
                targetPath = Path.Combine(path, Path.GetFileName(openFileDialog.FileName));

                File.Copy(openFileDialog.FileName, targetPath, true);
            }
        }

    }
}
