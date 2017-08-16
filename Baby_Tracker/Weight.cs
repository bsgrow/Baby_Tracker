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
        //Database Connection String
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";

        //Variable Declarations for statistics
        public static string averageWeight = "0";
        public static string minWeight = "0";
        public static string maxWeight = "0";
        public static string lastWeight = "0";
        public static string lastDate = "0";
        public static string gainWeight = "0";


        /*
         * Method allows for the information for the textboxes from the
         * WeightEntryForm to be recorded and saved into the table 
         * Weight in the database. BabyID is used as the name that is
         * selected in the combobox from the leftPanel
         */
        public void addWeight()
        {
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM Weight WHERE ID = '" + BabyTracker.weightID + "'";
                command.ExecuteNonQuery();
            }

        }


        /*
         * Allows for the Weight row selected to be updated. All the values
         * are now updated here and if there are blanks, then that is determined
         * in the MainFrame Form. 
         */
        public void updateEntry()
        {
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
            SQLiteCommand command;
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            command = new SQLiteCommand("SELECT avg(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            averageWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT min(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            minWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT max(Weight) FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "'", conn);
            maxWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT IFNULL ((SELECT Weight FROM Weight  WHERE BabyID = '" + BabyTracker.babyName + "' ORDER BY ID DESC limit 1), 0)", conn);
            lastWeight = command.ExecuteScalar().ToString();
            command = new SQLiteCommand("SELECT IFNULL ((SELECT Date FROM Weight WHERE BabyID = '" + BabyTracker.babyName + "' ORDER BY ID DESC limit 1), 0)", conn);
            lastDate = command.ExecuteScalar().ToString();
            if (lastWeight == "" | minWeight == "")
            {
                averageWeight = "0";
                minWeight = "0";
                maxWeight = "0";
                lastWeight = "0";
                lastDate = "0";
                gainWeight = "0";
            }
            else
            {
                gainWeight = Convert.ToString(Convert.ToInt32(lastWeight) - Convert.ToInt32(minWeight));
            }
            conn.Close();
        }
    }
}
