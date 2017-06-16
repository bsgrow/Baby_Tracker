using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Baby_Tracker
{
    class DatabaseCreation
    {
        SQLiteConnection connection;
        SQLiteCommand command;

        string sqlBabyTable = @"CREATE TABLE BabyList (
			 	ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
				FirstName VARCHAR(20) NOT NULL, 
				MiddleName VARCHAR(20) NULL, 
				LastName VARCHAR(20) NOT NULL, 
				DOB DATE NOT NULL,
				BirthWeight INTEGER NOT NULL, 
				BirthLength INTEGER NOT NULL, 
				BirthHeadCir INTEGER NOT NULL
				)";

        string sqlWeightTable = @"CREATE TABLE Weight (
			    ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
             
				Weight INTEGER NOT NULL, 
				Date DATE NULL
				)";

        string sqlMeasurementsTable = @"CREATE TABLE Measurements (
				ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
				
				Length INTEGER NULL,
				Waist INTEGER NULL,
				Head INTEGER NULL,
				Chest INTEGER NULL,
				Hips INTEGER NULL
				)";

        string sqlImmunizationsTable = @"CREATE TABLE Immunizations (
			    ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
				
				Name VARCHAR(100) NOT NULL,
				DateGiven DATE NULL,
				AdminBy VARCHAR(100) NULL,
				NextDose DATE NULL
				)";

        string sqlMedicationsTable = @"CREATE TABLE Medications (
				ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			
				Name VARCHAR(200) NOT NULL,
				Dosage INTEGER NOT NULL,
				Type VARCHAR(100) NULL,
				DateStarted DATE NULL,
				Refill INTEGER NULL
				)";

        string sqlDoctorAppointmentsTable = @"CREATE TABLE DoctorAppointments (
				ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
				Name VARCHAR(200) NOT NULL,
				Date DATE NOT NULL,
				Time VARCHAR NOT NULL,
				Location VARCHAR NULL,
				Doctor VARCHAR NULL
				)";

        string sqlDoctorContactTable = @"CREATE TABLE DoctorContacts (
				ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
				Name VARCHAR(200) NOT NULL,
				PhoneNumber INTEGER NOT NULL,
				Email VARCHAR(200) NOT NULL,
				Address VARCHAR(400) NULL
				)";



        public void databaseCreation()
        {

            if (!File.Exists("BabyDatabase.sqlite"))
            {  //need to set the file location

                Console.WriteLine("Database does not exist! Creating database now!");

                //Creating database and connection
                SQLiteConnection.CreateFile("BabyDatabase.sqlite"); //set location to a database folder
                connection = new SQLiteConnection("Data Source = BabyDatabase.sqlite; Version = 3;");
                connection.Open();

                //Creating the tables
                command = new SQLiteCommand(sqlBabyTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlWeightTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlMeasurementsTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlImmunizationsTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlMedicationsTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlDoctorAppointmentsTable, connection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sqlDoctorContactTable, connection);
                command.ExecuteNonQuery();

                //Closes the connection to the database
                connection.Close();

            }
            else
            {
                Console.WriteLine("Database already exists!");
            }

        }

    }
}
