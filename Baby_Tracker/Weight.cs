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

        //SQLite database declaration
        SQLiteConnection connection;
        SQLiteCommand command;

        
        //Variable Declarations for statistics
        public static string averageWeight = "";
        public static string minWeight = "0";
        public static string maxWeight = "";
        public static string lastWeight = "";
        public static string lastDate = "0";
        public static string gainWeight = "";
            
        


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
        
        
        /*
         * Calls the six queries that allow for the statstics to be displayed
         * on the statistic section on the weight panel.
         */
        public void weightStatistics()
        { 
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            command = new SQLiteCommand("SELECT avg(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            averageWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT min(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            minWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT max(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            maxWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT Weight FROM Weight  WHERE BabyID = '" + BabyTracker.babyName + "' ORDER BY ID DESC limit 1", conn);
            lastWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT Date FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "' ORDER BY ID DESC limit 1", conn);
            lastDate = command.ExecuteScalar().ToString();
            weightGained = Convert.ToString(Convert.ToInt32(lastWeight) - Convert.ToInt32(minWeight));
            conn.Close();
        }
            
    }
}
