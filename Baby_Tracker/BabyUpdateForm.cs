using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    public partial class BabyUpdateForm : Form
    {

        AddUpdateDeleteBaby addUpdateBaby = new AddUpdateDeleteBaby();

        //String declarations
        public static string updateFirstName = "";
        public static string updateMiddleName = "";
        public static string updateLastName = "";
        public static string updatedob = "";
        public static double updateWeight;
        public static double updateLength;
        public static double updateHeadCir;
        public static string updateImagePath = "";
        public static string comboName = "";


        public BabyUpdateForm()
        {
            InitializeComponent();
            updateComboBox();
        }


         /*
         * Upon click this will hide the for and not record any data that 
         * was entered by the user. To make sure that the textfields have
         * no data, the will be set to blank here.
         */
        private void updateCancel_btn_Click(object sender, EventArgs e)
        {
            emptyTextFields();
            Hide();
        }


        /*
         * Allows for the textboxes to be set to empty after a users input or 
         * if the user presses cancel. This method is called from both cancel 
         * and add buttons found on the BabyUpdateForm.
         */
        public void emptyTextFields()
        {
            updateFirstName_tbox.Text = "";
            updateMiddleName_tbox.Text = "";
            updateLastName_tbox.Text = "";
            updateDOB_tbox.Text = "";
            updateBirthWeight_tbox.Text = "";
            updateBirthLength_tbox.Text = "";
            updateBirthHead_tbox.Text = "";
            updatePathLocation_lb.Text = "";
        }


        /*
         * Calls the AddUpdateBaby to allow for the connection to update the 
         * certain fields that the user had updated. User does not have to update
         * every field. 
         */
        private void updateEntry_btn_Click(object sender, EventArgs e)
        {
            if(updateFirstName_tbox.Text == "" | updateDOB_tbox.Text == "" | updateBirthWeight_tbox.Text == "" | updateBirthLength_tbox.Text == "" | updateBirthHead_tbox.Text == "") {
                Message.Box("Either First Name, DOB, Weight, Length, Head Circumfirence are blank. Must have an entry!!");
            } else {
                updateFirstName = updateFirstName_tbox.Text;
                updateMiddleName = updateMiddleName_tbox.Text;
                updateLastName = updateLastName_tbox.Text;
                updatedob = updateDOB_tbox.Text;
                updateWeight = double.Parse(updateBirthWeight_tbox.Text);
                updateLength = double.Parse(updateBirthLength_tbox.Text);
                updateHeadCir = double.Parse(updateBirthHead_tbox.Text);
                updateImagePath = updatePathLocation_lb.Text;

                addUpdateBaby.updateBaby();
                 emptyTextFields();
                Hide();
            }
        }



        /*
         * Allows for a image the user chooses to be saved into the babies 
         * creation. The only files that will be accepted are JPEG/JPG and PNG
         * files. These images will then be saved to the BabyImages folder 
         * inside the application. Takes the file the user selects from OpenFileDialog
         * then copies it to the BabyImages folder. The path is retrieved here to get
         * the path and saves it to the database.
         */
        private void updateImage_btn_Click(object sender, EventArgs e)
        {
            addUpdateBaby.babyImagePath();
            updatePathLocation_lb.Text = addUpdateBaby.targetPath;
        }


        /*
     *  Calls the FirstName table from the SQLite database to be displayed inside
     *  the combob box. This is also set to refresh as a new baby is entered into the
     *  application.
     */
        public void updateComboBox()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    updateCombo.DisplayMember = "FirstName";
                    updateCombo.DataSource = dt;
                    connection.Close();
                }
            }
        }


        /*
         * Retrieves the seleted name in the combobox
         */
        private void updateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboName = updateCombo.GetItemText(updateCombo.SelectedItem);
        }
    }
}
