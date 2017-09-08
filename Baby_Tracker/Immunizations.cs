using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Tracker
{
    class Immunizations
    {
        //Database Connection String
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";


        public void addImmunization()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = "INSERT INTO Immunizations (ID, Name, DateGiven, Dosage, BabyID) VALUES (@id, @name, @dateGiven, @dosage, @babyID)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@name", BabyTracker.immName);
                command.Parameters.AddWithValue("@dateGiven", BabyTracker.immDateGiven);
                command.Parameters.AddWithValue("@dosage", BabyTracker.immDateGiven);
                command.Parameters.AddWithValue("@babyID", BabyTracker.babyName);

                conn.Open();
                command.ExecuteNonQuery();

            }
        }


        public void updateImmunization()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "UPDATE Immunizations SET Name = @name, DateGiven = @dateGiven, Dosage = @dosage  WHERE ID = '" + BabyTracker.immunizationID + "'";
                command.Parameters.AddWithValue("@name", BabyTracker.immName);
                command.Parameters.AddWithValue("@dateGiven", BabyTracker.immDateGiven);
                command.Parameters.AddWithValue("@dosage", BabyTracker.immDateGiven);
                command.ExecuteNonQuery();
            }
        }

        public void deleteImmunization()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM Immunizations WHERE ID = '" + BabyTracker.immunizationID + "'";
                command.ExecuteNonQuery();
            }

        }
    }
}
