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

        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";


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
            