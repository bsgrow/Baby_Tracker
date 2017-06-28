using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Baby_Tracker
{
    public partial class BabyEntryForm : Form
    {
        //String declarations
        public static string firstName = "";
        public static string middleName = "";
        public static string lastName = "";
        public static string dob = "";
        public static double weight;
        public static double length ;
        public static double headCir;
        public static string imagePath = "";


        public BabyEntryForm()
        {
            InitializeComponent();
        }


        /*
         * Allows for the textbox data from the users input to be record into
         * the database. This calls the class Addbaby, which is where the 
         * application then converts and store information into the database
         * table "BabyList".
         * 
         * Also, a kill feature is enabled to complete closing the form.
         */
        private void addEntry_btn_Click(object sender, EventArgs e)
        {
            //Sets the textbox inputs to a string for accessablity throughout application
            firstName = firstName_tbox.Text;
            middleName = middleName_tbox.Text;
            lastName = lastName_tbox.Text;
            dob = dob_tbox.Text;
            weight = double.Parse(weight_tbox.Text);
            length = double.Parse(length_tbox.Text);
            headCir = double.Parse(head_tbox.Text);
            imagePath = pathLocation_lb.Text;//shows the user the file path in the form once selected

            //Calls addbaby to add data to the database and close the input form
            AddBaby addBaby = new AddBaby();
            addBaby.connection();

            this.Hide();
            emptyTextFields();

            BabyTracker babyTracker = new BabyTracker();
            babyTracker.comboBoxNameRetrival();

        }


        /*
         * Upon click this will hide the for and not record any data that 
         * was entered by the user. To make sure that the textfields have
         * no data, the will be set to blank here.
         */
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            emptyTextFields();
            Hide();
        }


        /*
         * Allows for the textboxes to be set to empty after a users input or 
         * if the user presses cancel. This method is called from both cancel 
         * and add buttons found on the BabyEntryForm.
         */
        public void emptyTextFields()
        {

            firstName_tbox.Text = "";
            middleName_tbox.Text = "";
            lastName_tbox.Text = "";
            dob_tbox.Text = "";
            weight_tbox.Text = "";
            length_tbox.Text = "";
            head_tbox.Text = "";
            pathLocation_lb.Text = "";
        
        }


        /*
         * Allows for a image the user chooses to be saved into the babies 
         * creation. The only files that will be accepted are JPEG/JPG and PNG
         * files. These images will then be saved to the BabyImages folder 
         * inside the application. Takes the file the user selects from OpenFileDialog
         * then copies it to the BabyImages folder. The path is retrieved here to get
         * the path and saves it to the database.
         */
        private void addImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Selet Baby Profile Image";
            openFileDialog1.Filter =  "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = @"C:\Users\Brandon\Documents\Visual Studio 2017\Projects\Baby_Tracker\Baby_Tracker\BabyImages"; //save to file location
                string targetPath = Path.Combine(path, Path.GetFileName(openFileDialog1.FileName));

                File.Copy(openFileDialog1.FileName, targetPath, true);
                pathLocation_lb.Text = openFileDialog1.FileName;
            }
        } 
        
    }
}
