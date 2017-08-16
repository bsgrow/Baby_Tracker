using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Tracker
{
    class Measurements
    {
        //variable declarations
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
        
        
        /*
         * Method allows for the user to save new data from the measurements
         * panel into the Measurements table in the database. There is no
         * requirement that all entry have a value, but at least one entry
         * must contain a value to be valid.
         */
        public void addMeasurements() 
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "INSERT INTO Measurements (ID, Length, Waist, Head, Chest, Hips) VALUES (@id, @length, @waist, @head, @chest, @hips)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@length", BabyTracker.measurementsLength);
                command.Parameters.AddWithValue("@waist", BabyTracker.measurementsWaist);
                command.Parameters.AddWithValue("@head", BabyTracker.measurementsHead);
                command.Parameters.AddWithValue("@chest", BabyTracker.measurementsChest);
                command.Parameters.AddWithValue("@hips", BabyTracker.measurementsHips);
                command.ExecuteNonQuery();

            }
        }
        
        
        /*
         * Method allows for previous entry to be updated. All entrys are updated
         * during each save for each record. Again, not all entrys have to have a 
         * value, but there must me one value per record to make the entry valid. 
         */
        public void updateMeasurements()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "UPDATE Measurements SET Length = @length, Waist = @waist, Head = @head, Chest = @chest, Hips = @hips  WHERE ID = '" + BabyTracker.measurementID + "'";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@length", BabyTracker.measurementsLength);
                command.Parameters.AddWithValue("@waist", BabyTracker.measurementsWaist);
                command.Parameters.AddWithValue("@head", BabyTracker.measurementsHead);
                command.Parameters.AddWithValue("@chest", BabyTracker.measurementsChest);
                command.Parameters.AddWithValue("@hips", BabyTracker.measurementsHips);
                command.ExecuteNonQuery();
            }
        }
        
        
        /*
         * Method allows for a record to be deleted that the user has selected
         * from the database and datatable "Measurements".
         */
        public void deleteMeasurements()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM Measurements WHERE ID = '" + BabyTracker.measurementID + "'";
                command.ExecuteNonQuery();
            }
        }
    
    }
    
}
