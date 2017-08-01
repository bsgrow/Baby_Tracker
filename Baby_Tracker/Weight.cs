using System;
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
                command.Parameters.AddWithValue("@weight", BabyTracker.weightEntry);
                command.Parameters.AddWithValue("@date", BabyTracker.dateEntry);
                command.Parameters.AddWithValue("@babyID", BabyTracker.babyName);

                conn.Open();
                command.ExecuteNonQuery();

            }
        }


        /*
         * Allows for the information that the user has selected from the 
         * data table to be retrieved. Once the data is retrieved then the
         * data is called here and the data is then deleted from the database
         * table "Weight"
         */ 
        public void deleteEntry()
        {
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM Weight WHERE ID = '" + BabyTracker.weightID + "'";
                command.ExecuteNonQuery();
            }

        }


        public void updateEntry()
        {
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "UPDATE Weight SET Weight = @weight, Date = @date  WHERE ID = '" + BabyTracker.weightID + "'";
                command.Parameters.AddWithValue("@weight", BabyTracker.weightEntry);
                command.Parameters.AddWithValue("@date", BabyTracker.dateEntry);
                command.ExecuteNonQuery();
            }
        }


        public void weightStatistics()
        {
           
        }
    }
}