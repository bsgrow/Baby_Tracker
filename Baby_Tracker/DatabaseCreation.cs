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
        //Pre-set image path locations for babies user profile
        public static string bg1 = @"C:\Users\Brandon\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyGirl1.png";
        public static string bg2 = @"C:\Users\Brandon\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyGirl2.png";
        public static string bb1 = @"C:\Users\Brandon\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyBoy1.png";
        public static string bb2 = @"C:\Users\Brandon\Documents\GitHub\Baby_Tracker\Baby_Tracker\BabyProfileImages\BabyBoy2.png";

        SQLiteConnection connection;
        SQLiteCommand command;

        string sqlBabyTable = @"CREATE TABLE BabyList (
			 	ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
				FirstName VARCHAR(20) NOT NULL, 
				MiddleName VARCHAR(20) NULL, 
				LastName VARCHAR(20) NULL, 
				DOB VARCHAR(9) NOT NULL,
				BirthWeight INTEGER NOT NULL, 
				BirthLength INTEGER NOT NULL, 
				BirthHeadCir INTEGER NOT NULL,
				BabyImagePath VARCHAR(250) NULL
				)";

        string sqlProfileImages = @"CREATE TABLE ProfileImages (
                ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                ImageName VARCHAR(40) NOT NULL,
                ImagePath VARCHAR(250) NOT NULL
                )";

        string sqlWeightTable = @"CREATE TABLE Weight (
			    ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
				Weight INTEGER NOT NULL, 
				Date VARCHAR(9) NOT NULL,
                BabyID VARCHAR(50) NOT NULL
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
				OfficeName VARCHAR(200) NULL,
                FirstName VARCHAR(200) NULL,
                LastName VARCHAR(200) NULL,
                Address VARCHAR(200) NULL,
                City VARCHAR(200) NULL,
                State VARCHAR(200) NULL,
                ZipCode INTEGER NULL,
				PhoneNumber VARCHAR(12) NULL,
				Email VARCHAR(200) NULL
				)";



        public void databaseCreation()
        {
            //Creating database and connection
            SQLiteConnection.CreateFile("BabyDatabase.sqlite"); //set location to a database folder
            connection = new SQLiteConnection("Data Source = BabyDatabase.sqlite; Version = 3;");
            connection.Open();

            //Creating the tables
            command = new SQLiteCommand(sqlBabyTable, connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(sqlProfileImages, connection);
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

            //inserts the Profile images into the database (ProfileImages Table)
            command.CommandText = "INSERT INTO ProfileImages (ID, ImageName, ImagePath) VALUES (null, 'Baby Girl 1', '" + bg1 + "')";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO ProfileImages (ID, ImageName, ImagePath) VALUES (null, 'Baby Girl 2', '" + bg2 + "')";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO ProfileImages (ID, ImageName, ImagePath) VALUES (null, 'Baby Boy 1', '" + bb1 + "')";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO ProfileImages (ID, ImageName, ImagePath) VALUES (null, 'Baby Boy 2', '" + bb2 + "')";
            command.ExecuteNonQuery();

            //Closes the connection to the database
            connection.Close();
        }

    }
}
