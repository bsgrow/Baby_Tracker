using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baby_Tracker
{
    class DoctorContacts
    {
        //Database String Connection
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";


        /*
         * Allows for the a new contact to be added to the Doctor Contacts table
         * in the database. This method calls the variable from MainForm and then 
         * saves them datatable. Blanks are excepted and determined in MainForm.
         */
        public void newContactEntry()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = @"INSERT INTO DoctorContacts (ID, OfficeName, FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email) 
                                        VALUES (@id, @officeName, @firstName, @lastName, @address, @city, @state, @zipcode,@phoneNumber, @email)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@officeName", BabyTracker.officeNameDoc);
                command.Parameters.AddWithValue("@firstName", BabyTracker.firstNameDoc);
                command.Parameters.AddWithValue("@lastName", BabyTracker.lastNamedoc);
                command.Parameters.AddWithValue("@address", BabyTracker.addressDoc);
                command.Parameters.AddWithValue("@city", BabyTracker.cityDoc);
                command.Parameters.AddWithValue("@state", BabyTracker.stateDoc);
                command.Parameters.AddWithValue("@zipcode", BabyTracker.zipCodeDoc);
                command.Parameters.AddWithValue("@phoneNumber", BabyTracker.phoneNumDoc);
                command.Parameters.AddWithValue("@email", BabyTracker.emailDoc);

                conn.Open();
                command.ExecuteNonQuery();

            }
        }


        /*
         * Allows for the textboxes from the MainFrame to be called that contains the information
         * from the Doctor Contacts panel. This allows for the datatable to be updated once the user 
         * selects to save the current entries. 
         */
        public void updateContactEntry()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = @"UPDATE DoctorContacts SET OfficeName = @officeName, FirstName = @firstName, LastName = @lastName, 
                                        Address = @address, City = @city, State = @state, ZipCode = @zipcode, PhoneNumber = @phoneNumber,
                                        Email = @email WHERE ID = '" + BabyTracker.contactID + "'";
                command.Parameters.AddWithValue("@officeName", BabyTracker.officeNameDoc);
                command.Parameters.AddWithValue("@firstName", BabyTracker.firstNameDoc);
                command.Parameters.AddWithValue("@lastName", BabyTracker.lastNamedoc);
                command.Parameters.AddWithValue("@address", BabyTracker.addressDoc);
                command.Parameters.AddWithValue("@city", BabyTracker.cityDoc);
                command.Parameters.AddWithValue("@state", BabyTracker.stateDoc);
                command.Parameters.AddWithValue("@zipcode", BabyTracker.zipCodeDoc);
                command.Parameters.AddWithValue("@phoneNumber", BabyTracker.phoneNumDoc);
                command.Parameters.AddWithValue("@email", BabyTracker.emailDoc);
                command.ExecuteNonQuery();
            }
        }


        /*
         * Allows for a selected contact to be deleted by the user. Calles the ID
         * on the table to compare with the ID in the database to delete. 
         */
        public void deleteContactEntry()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {
                conn.Open();
                command.CommandText = "DELETE FROM DoctorContacts WHERE ID = '" + BabyTracker.contactID + "'";
                command.ExecuteNonQuery();
            }

        }
    }
}

