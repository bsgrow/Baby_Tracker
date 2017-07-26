﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Tracker
{
    class Weight
    {

        /*
         * Method allows for the information for the textboxes from the
         * WeightEntryForm to be recorded and saved into the table 
         * Weight in the database. BabyID is used as the name that is
         * selected in the combobox from the leftPanel
         */
        public void addWeight()
        {
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = "INSERT INTO Weight (ID, Weight, Date, BabyID) VALUES (@id, @weight, @date, @babyID)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@weight", WeightEntryForm.weightEntry);
                command.Parameters.AddWithValue("@date", WeightEntryForm.dateEntry);
                command.Parameters.AddWithValue("@babyID", BabyTracker.babyName);

                conn.Open();
                command.ExecuteNonQuery();

            }
        }


        public void deleteEntry()
        {

        }
    }
}
