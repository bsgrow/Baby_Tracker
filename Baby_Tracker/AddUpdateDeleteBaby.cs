﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    class AddUpdateDeleteBaby
    {
        //Data Source = C:\\Program Files (x86)/Baby Tracker/BabyDatabase.sqlite; Version=3;
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";


        /*
         * Method is using the data from the BabyEntryForm textboxes to create a new row for
         * each new baby entered. The connection and all database requires are set up here. 
         * BabyList is the table that is being used for the storage of the information.
         */
        public void addBaby()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = conn.CreateCommand())
                {
                    conn.Open();

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
                    command.Parameters.AddWithValue("@firstName", BabyEntryForm.firstName);
                    command.ExecuteNonQuery();
                }


                using (SQLiteCommand command = conn.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Weight (Weight, Date, BabyID) VALUES (@birthWeight, @DOB, @babyID)";
                    //command.Parameters.AddWithValue("@id", null);
                    command.Parameters.AddWithValue("@birthWeight", BabyEntryForm.weight);
                    command.Parameters.AddWithValue("@DOB", BabyEntryForm.dob);
                    command.Parameters.AddWithValue("@babyID", BabyEntryForm.firstName);
                    command.ExecuteNonQuery();
                }


                using (SQLiteCommand command = conn.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Measurements (ID, Length, Waist, Head, Chest, Hips, Date, BabyID) VALUES (@id, @birthLength, 0, @birthHeadCir, 0, 0, @date, @babyID)";
                    command.Parameters.AddWithValue("@id", null);
                    command.Parameters.AddWithValue("@birthLength", BabyEntryForm.length);
                    command.Parameters.AddWithValue("@birthHeadCir", BabyEntryForm.headCir);
                    command.Parameters.AddWithValue("@firstName", BabyEntryForm.firstName);
                    command.Parameters.AddWithValue("@date", BabyEntryForm.dob);
                   command.Parameters.AddWithValue("@babyID", BabyEntryForm.firstName);

                    command.ExecuteNonQuery();
                }
            }
        }



        /* Connections to the database to use the information entered from the
         * BabyUpdateForm to update the database based upon the fields that 
         * have entered data.
         */
        public void updateBaby()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = "UPDATE BabyList SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, DOB = @DOB, BirthWeight = @birthWeight, BirthLength = @birthLength, BirthHeadCir = @birthHeadCir, BabyImagePath = @babyImagePath WHERE FirstName = '" + BabyUpdateForm.comboName + "'";
                    command.Parameters.AddWithValue("@firstName", BabyUpdateForm.updateFirstName);
                    command.Parameters.AddWithValue("@middleName", BabyUpdateForm.updateMiddleName);
                    command.Parameters.AddWithValue("@lastName", BabyUpdateForm.updateLastName);
                    command.Parameters.AddWithValue("@DOB", BabyUpdateForm.updatedob);
                    command.Parameters.AddWithValue("@birthWeight", BabyUpdateForm.updateWeight);
                    command.Parameters.AddWithValue("@birthLength", BabyUpdateForm.updateLength);
                    command.Parameters.AddWithValue("@birthHeadCir", BabyUpdateForm.updateHeadCir);
                    command.Parameters.AddWithValue("@babyImagePath", BabyUpdateForm.updateImagePath);
                    command.ExecuteNonQuery();
                }
                
                
                using (SQLiteCommand command = conn.CreateCommand())
                {
                    command.CommandText = "UPDATE Weight SET BirthWeight = @birthWeight, DOB = @DOB WHERE ID = '" + BabyTracker.weightID + "'";
                    command.Parameters.AddWithValue("@birthWeight", BabyUpdateForm.updateWeight);
                    command.Parameters.AddWithValue("@DOB", BabyUpdateForm.updatedob);
                    command.ExecuteNonQuery();
                }
                
                
                using (SQLiteCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = "UPDATE BabyList SET  DOB = @DOB, BirthWeight = @birthWeight, BirthLength = @birthLength, BirthHeadCir = @birthHeadCir WHERE FirstName = '" + BabyTracker.weightID + "'";
                    command.Parameters.AddWithValue("@birthWeight", BabyUpdateForm.updateWeight);
                    command.Parameters.AddWithValue("@birthLength", BabyUpdateForm.updateLength);
                    command.Parameters.AddWithValue("@birthHeadCir", BabyUpdateForm.updateHeadCir);
                    command.ExecuteNonQuery();
                }
            }

        }


        /* Connects to the database to allow for the user to delete a baby 
         * entry that they have previously made. Once a baby is deleted 
         * from the database, all data is lost on the baby and must
         * be reentered as a new baby.
         */
        public void deletebaby()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM BabyList WHERE FirstName = '" + BabyDeleteForm.comboName + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM Weight WHERE BabyID = '" + BabyDeleteForm.comboName + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM Measurements WHERE BabyID = '" + BabyDeleteForm.comboName + "'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM Immunizations WHERE BabyID = '" + BabyDeleteForm.comboName + "'";
                command.ExecuteNonQuery();
            }

        }
    }
}




