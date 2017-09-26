using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Tracker
{
    class Medications
    {
        //Database Connection String
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
        
       
        /*
         * Method allows for the information for the textboxes from the
         * Medications Panel to be recorded and saved into the table 
         * Medication in the database. BabyID is used as the name that is
         * selected in the combobox from the leftPanel
         */
        public void addMedication()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = @"INSERT INTO Medications (ID, Name, Dosage, Type, DateStarted, Refill, Pharmacy, TakenTime, PrescribingDoc, BabyID) 
                                        VALUES (@id, @name, @dosage, @type, @dateStarted, @refill, @pharmacy, @takenTime, @prescribingDoc, @babyID)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@name", BabyTracker.medName);
                command.Parameters.AddWithValue("@dosage", BabyTracker.medDosage);
                command.Parameters.AddWithValue("@type", BabyTracker.medType);
                command.Parameters.AddWithValue("@dateStarted", BabyTracker.medDateStarted);
                command.Parameters.AddWithValue("@refill", BabyTracker.medRefill);
                command.Parameters.AddWithValue("@pharmacy", BabyTracker.medPharmacy);
                command.Parameters.AddWithValue("@takenTime", BabyTracker.medTakenTime);
                command.Parameters.AddWithValue("@prescribingDoc", BabyTracker.medPrescribingDoc);
                command.Parameters.AddWithValue("@babyID", BabyTracker.babyName);

                conn.Open();
                command.ExecuteNonQuery();

            }
        }
        
        
        
         /*
         * Allows for the Medication row selected to be updated. All the values
         * are now updated here and if there are blanks, then that is determined
         * in the MainFrame Form. 
         */
        public void updateMedicationEntry()
        {

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = @"UPDATE Medications SET Name = @name, Dosage = @dosage, Type = @type, 
                                        DateStarted = @dateStarted, Refill = @refill, Pharmacy = @pharmacy, TakenTime = @takenTime, 
                                        PrescribingDoc = @prescribingDoc, BabyID = @babyID 
                                        WHERE ID = '" + BabyTracker.medicationID + "'";

                command.Parameters.AddWithValue("@name", BabyTracker.medName);
                command.Parameters.AddWithValue("@dosage", BabyTracker.medDosage);
                command.Parameters.AddWithValue("@type", BabyTracker.medType);
                command.Parameters.AddWithValue("@dateStarted", BabyTracker.medDateStarted);
                command.Parameters.AddWithValue("@refill", BabyTracker.medRefill);
                command.Parameters.AddWithValue("@pharmacy", BabyTracker.medPharmacy);
                command.Parameters.AddWithValue("@takenTime", BabyTracker.medTakenTime);
                command.Parameters.AddWithValue("@prescribingDoc", BabyTracker.medPrescribingDoc);
                command.Parameters.AddWithValue("@babyID", BabyTracker.babyName);
                command.ExecuteNonQuery();
            }
        }


        /*
         * Allows for the information that the user has selected from the 
         * data table to be retrieved. Once the data is retrieved then the
         * data is called here and the data is then deleted from the database
         * table "Medication"
         */
        public void deleteMedicationEntry()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM Medications WHERE ID = '" + BabyTracker.medicationID + "'";
                command.ExecuteNonQuery();
            }

        }
    }
}
