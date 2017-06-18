using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

/*
 * This class is used to store the inputs from the Add Baby Entry form. Here
 * the users input will be store into a SQLite database, where the table is called
 * BabyList.
 */
namespace Baby_Tracker
{
   public class AddBaby : BabyEntryForm
    {

        /*
         * Method is using the data from the BabyEntryForm textboxes to create a new row for
         * each new baby entered. The connection and all database requires are set up here. 
         * 
         * Note: DatabaseCreation class is called to either create a new database or check to see is there is a database
         * 
         */
        public void connection()
        {
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = conn.CreateCommand())
            {

                command.CommandText = "INSERT INTO BabyList (ID, FirstName, MiddleName, LastName, DOB, BirthWeight, BirthLength, BirthHeadCir) VALUES (@id, @firstName, @middleName, @lastName, @DOB, @birthWeight, @birthLength, @birthHeadCir)";
                command.Parameters.AddWithValue("@id", null);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@middleName", middleName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@DOB", dob);
                command.Parameters.AddWithValue("@birthWeight", weight);
                command.Parameters.AddWithValue("@birthLength", length);
                command.Parameters.AddWithValue("@birthHeadCir", headCir);

                conn.Open();
                command.ExecuteNonQuery();

                /* Used to test the information from the database for BabyList table
                string sql = "select * from BabyList";
                SQLiteCommand command1 = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                    Console.WriteLine("ID: " + reader["ID"] + "\tWeight: " + reader["BirthWeight"] + "\tDate: " + reader["DOB"]);
                */
            }

        }

    }
}
