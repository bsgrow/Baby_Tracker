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

namespace Baby_Tracker
{
    public partial class BabyTracker : Form
    {
    
        //Access to other classes and forms
        BabyEntryForm babyEntryForm = new BabyEntryForm();
        BabyUpdateForm babyUpdateForm = new BabyUpdateForm();
        BabyDeleteForm babyDeleteForm = new BabyDeleteForm();
        ReportExports reportExports = new ReportExports();
        Weight weightClass = new Weight();
        DoctorContacts doctorContacts = new DoctorContacts();
        Measurements measurementsClass = new Measurements();

        //Allows for the weight and baby to be called in other classes for data entry
        public static string babyName = ""; //declares the baby name from the main combobox in the left panel
        public static double weightEntry = 0;
        public static string dateEntry = "";
        public static int weightID = 0;

        //Doctor Contacts declarations for database
        public static int contactID = 0;
        public static string officeNameDoc = "";
        public static string firstNameDoc = "";
        public static string lastNamedoc = "";
        public static string addressDoc = "";
        public static string cityDoc = "";
        public static string stateDoc = "";
        public static string zipCodeDoc = "";
        public static string phoneNumDoc = "";
        public static string emailDoc = "";
        
        //Measurement declarations for database
        public static int measurementsID = 0;
        public static string measurementsLength = "";
        public static string measurementsWaist = "";
        public static string measurementsHead = "";
        public static string measurementsChest = "";
        public static string measurementsHips = "";
        
        //Database connection string
        string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";


        public BabyTracker()
        {
            InitializeComponent();
            comboBoxNameRetrival();
            weightDataTable();
            doctorContactDataTable();
            measurementDataTable();

        }


        /*
        *  Allows for the BabyEntryForm to be opened for the user to 
        *  add a new entry for a baby. Also, will update comboboxes.
        */
        private void newBaby_btn_Click(object sender, EventArgs e)
        {
            babyEntryForm.ShowDialog();
            comboBoxNameRetrival();
        }


        /*
       *  Allows for the BabyUpdateForm to be opened for the user to 
       *  add a updated entry for a baby. Also, will update comboboxes.
       */
        private void editBaby_btn_Click(object sender, EventArgs e)
        {
            babyUpdateForm.updateComboBox();
            babyUpdateForm.ShowDialog();
            comboBoxNameRetrival();
        }


        /*
         * Calls the BabyDeleteForm to allow for the user to delete an
         * baby entry. Also, will update comboboxes.
         */
        private void deleteBaby_btn_Click(object sender, EventArgs e)
        {
            babyDeleteForm.updateDeleteCombo();
            babyDeleteForm.ShowDialog();
            comboBoxNameRetrival();
        }


        /*
         * Calls the ReportExports class to allows for the excel function
         * to be activated to export a excel spreadsheet to the desired location.
         * (Only for Baby List)
         */
        private void babyListExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportExports.excelExport();
        }


        /*
         * Calls the ReportExports class to allow for the PDF function to be
         * activated to export a PDF to the desired location. (Only for Baby List)
         */
        private void babyListPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportExports.pdfExport();
        }


        /*
        *  Calls the FirstName table from the SQLite database to be displayed inside
        *  the combob box. This is also set to refresh as a new baby is entered into the
        *  application.
        */
        public void comboBoxNameRetrival()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT FirstName FROM BabyList", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    babySelector_cmbo.DisplayMember = "FirstName";
                    babySelector_cmbo.DataSource = dt;
                    connection.Close();
                }
            }
        }


        /*
        * Allows for the Image box to be updated based upon the selected name
        * that is found within the combobox. Image is found within the database
        * table BabyList, where the path to the image is saved. THerefore, that image
        * path is then added to the image box for display based upon the user
        */
        private void babySelector_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem); //loads the selected name from combobox to theis label
            babyName = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem); //sets he combobox to be saved as a string

            string query = "SELECT BabyImagePath FROM BabyList where FirstName = '" + babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string result = Convert.ToString(reader["BabyImagePath"]);
                if (result == "")
                {
                    //do nothing
                }
                else
                {
                    userImage_box.Image = Image.FromFile(result);
                    weightDataTable();
                    weightPanel_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'s Weight";
                    measurementDataTable();
                    measurementsPanel_lb.Text = babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'s Measurements";



                }
            }
        }

        //Shows weight panel
        private void button6_Click(object sender, EventArgs e)
        {
            testPanel.BringToFront();
        }

        //Shows dashboard panel
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardPanel.BringToFront();
        }

        //Shows measurements Panel
        private void button1_Click(object sender, EventArgs e)
        {
            measurementsPanel.BringToFront();
        }

        //Shows immunization Panel
        private void button2_Click(object sender, EventArgs e)
        {
            immunizationsPanel.BringToFront();
        }

        //Shows medications Panel
        private void button7_Click(object sender, EventArgs e)
        {
            medicationsPanel.BringToFront();
        }

        //Shows appointments Panel
        private void button3_Click(object sender, EventArgs e)
        {
            appointmentsPanel.BringToFront();
        }

        //Shows Doctor Contact Panel
        private void button4_Click(object sender, EventArgs e)
        {
            doctorContactsPanel.BringToFront();
        }

        //Shows Growth Stats Panel
        private void button5_Click(object sender, EventArgs e)
        {
            growthStatsPanel.BringToFront();
        }




        /// <WEIGHTPANEL>

        public void clearWeightTextboxes()
        {
            weightEntry_tbox.Text = "";
            dateEntry_tbox.Text = "";
        }


        /*
         * Loads the weight gridviewtable in the weight panel. THis 
         * is queried based on the name selected from the combobox
         * on the left panel. This will change the weights based of
         * of that selection. 
         */
        public void weightDataTable()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT ID, Weight, Date FROM Weight where BabyID = '" + babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    weightDataView.DataSource = dt;
                    this.weightDataView.Columns[0].Visible = false;
                    weightStatistics();
                    weightChartMethod();
                }
            }
        }


        /*
         * Allows for the weightEntry panel to be shown. Here the
         * user will be able to entry a new weight for the user selected 
         * in the left panel combobox.
         */
        private void weightEntry_btn_Click(object sender, EventArgs e)
        {
            if (weightEntry_tbox.Text == "" | dateEntry_tbox.Text == "")
            {
                MessageBox.Show("Both Weight and Date must have an Entry to save!");
            }
            else
            {
                weightEntry = double.Parse(weightEntry_tbox.Text);
                dateEntry = dateEntry_tbox.Text;
                weightClass.addWeight();
                weightDataTable();
                MessageBox.Show("New Weight Was Added!!");
            }
        }


        /*
         * Allows for a row that has been selected from the table to be
         * permentatly deleted from the table and the database. 
         */
        private void deleteWeight_btn_Click(object sender, EventArgs e)
        {
            weightClass.deleteEntry();
            weightDataTable();
            clearWeightTextboxes();
            MessageBox.Show("Entry was succesfully deleted!!");
        }


        /*
         * Allows for a double click to be called in the data table. When a 
         * click is found on the data table then the row that is click data
         * will be displayed in the weight textboxes below the table view. Here
         * the user can then choose what they woudl like to do with double click 
         * selection.
         */
        private void weightTableView_Click(object sender, EventArgs e)
        {
            if (weightDataView.CurrentRow.Index != -1)
            {
                weightID = Convert.ToInt32(weightDataView.CurrentRow.Cells[0].Value.ToString());
                weightEntry_tbox.Text = weightDataView.CurrentRow.Cells[1].Value.ToString();
                dateEntry_tbox.Text = weightDataView.CurrentRow.Cells[2].Value.ToString();
            }
        }


        /*
         * Allows for the weight that has been previously entered to be
         * edit and then saved via the Weight Panel. 
         */
        private void updateWeight_btn_Click(object sender, EventArgs e)
        {
            if (weightEntry_tbox.Text == "" | dateEntry_tbox.Text == "")
            {
                MessageBox.Show("Both Weight and Date must have an Entry to save!");
            }
            else
            {
                weightEntry = double.Parse(weightEntry_tbox.Text);
                dateEntry = dateEntry_tbox.Text;
                weightClass.updateEntry();
                weightDataTable();
                clearWeightTextboxes();
                MessageBox.Show("Entry was successfully updated!!");
            }
        }

        /*
         * Calls the six queries that allow for the statstics to be displayed
         * on the statistic section on the weight panel.
         */
        public void weightStatistics()
        { 
            weightClass.weightStatistics();
            averageWeight_Text.Text = Weight.averageWeight;
            minWeight_text.Text = Weight.minWeight;
            maxWeight_Text.Text = Weight.maxWeight;
            lastWeight_Text.Text = Weight.lastWeight;
            lastDate_Text.Text = Weight.lastDate;
            weightGained_Text.Text = Weight.gainWeight;
            
        }


         /*
         * Allows for the data from the database to be displayed the graphs 
         * shown in the Weigth panel. These data points
         * are used from the Weight Table in the database.
         */
        public void weightChartMethod()
        {
            string weightQuery = "SELECT * FROM Weight WHERE BabyID = '"+babyName+"'";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(weightQuery, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                weightChart.Series["Weight"].Points.Clear();
                while (reader.Read())
                {
                    weightChart.Series["Weight"].Points.AddXY(reader[0], reader[1]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error in loading Chart!" +ex);
            }
        }



        ///
        /// Doctor Contacts Panel
        /// 

        
        /*
         * Allows for the doctor contact datatable to be called and then 
         * the data found there is then loaded into the Datatable in the
         * Measurements Panel. The first column is not visable in the 
         * table view itself.
         */
        public void doctorContactDataTable()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM DoctorContacts", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    doctorContactTable.DataSource = dt;
                    this.doctorContactTable.Columns[0].Visible = false;
                   
                }
            }
        }


        /*
         * Allows for a new contact to be entered. There mus tbe an entry for
         * office name and phone #. Then those entrys are give to a variable
         * and called in another class to be added to the datatable. Here
         * all the sections dynamically updated and loaded after the button 
         * is completed. A message box is display for comformation.
         */
        private void newContact_btn_Click(object sender, EventArgs e)
        {

            if (docOfficeName_tbox.Text == "" | docPhone_tbox.Text == "")
            {
                MessageBox.Show("Contact must contain a Office Name and Phone Number!");
            }
            else
            {
                officeNameDoc = docOfficeName_tbox.Text;
                firstNameDoc = docFirstName_tbox.Text;
                lastNamedoc = docLastName_tbox.Text;
                addressDoc = docAddress1_tbox.Text;
                cityDoc = docCity_tbox.Text;
                stateDoc = docState_tbox.Text;
                zipCodeDoc = docZip_tbox.Text;
                phoneNumDoc = docPhone_tbox.Text;
                emailDoc = docEmail_tbox.Text;
                doctorContacts.newContactEntry();
                doctorContactDataTable();
                clearContactTextboxes();
                MessageBox.Show("New Contact was added!");
            }
        }


        /*
         * When the user selects a row in the table view, then this method allows
         * for that data to be collected and displayed to the textboxes in the 
         * contact Panel. 
         */
        private void doctorContactTable_Click(object sender, EventArgs e)
        {
            if (doctorContactTable.CurrentRow.Index != -1)
            {
                contactID = Convert.ToInt32(doctorContactTable.CurrentRow.Cells[0].Value.ToString());
                docOfficeName_tbox.Text = doctorContactTable.CurrentRow.Cells[1].Value.ToString();
                docFirstName_tbox.Text = doctorContactTable.CurrentRow.Cells[2].Value.ToString();
                docLastName_tbox.Text = doctorContactTable.CurrentRow.Cells[3].Value.ToString();
                docAddress1_tbox.Text = doctorContactTable.CurrentRow.Cells[4].Value.ToString();
                docCity_tbox.Text = doctorContactTable.CurrentRow.Cells[5].Value.ToString();
                docState_tbox.Text = doctorContactTable.CurrentRow.Cells[6].Value.ToString();
                docZip_tbox.Text = doctorContactTable.CurrentRow.Cells[7].Value.ToString();
                docPhone_tbox.Text = doctorContactTable.CurrentRow.Cells[8].Value.ToString();
                docEmail_tbox.Text = doctorContactTable.CurrentRow.Cells[9].Value.ToString();
            }
        }


        /*
         * Allows for the selected row to be edited by the user. Office Name
         * and Office phone # must ahve an entry for the contact to be updated.
         * Once that is comformed, then the textboxes are saved to a varaible
         * and then called from another class to save the edits. Then the
         * contacts are updated and the table is refreshed and the textboxes
         * are cleared.
         */
        private void editContact_btn_Click(object sender, EventArgs e)
        {

            if (docOfficeName_tbox.Text == "" | docPhone_tbox.Text == "")
            {
                MessageBox.Show("Contact must contain a Office Name and Phone Number!");
            }
            else
            {
                officeNameDoc = docOfficeName_tbox.Text;
                firstNameDoc = docFirstName_tbox.Text;
                lastNamedoc = docLastName_tbox.Text;
                addressDoc = docAddress1_tbox.Text;
                cityDoc = docCity_tbox.Text;
                stateDoc = docState_tbox.Text;
                zipCodeDoc = docZip_tbox.Text;
                phoneNumDoc = docPhone_tbox.Text;
                emailDoc = docEmail_tbox.Text;
                doctorContacts.updateContactEntry();
                doctorContactDataTable();
                clearContactTextboxes();
                MessageBox.Show("New Contact was Updated!");
            }
        }

        
        /*
         * Button allows for the correct methods to be called to allow
         * for a deletion of a selected row in the datatable. Here all
         * the textboxes and table are then updated dynamically to 
         * reflex the changes. 
         */
        private void deleteContact_btn_Click(object sender, EventArgs e)
        {
            doctorContacts.deleteContactEntry();
            doctorContacts.updateContactEntry();
            doctorContactDataTable();
            clearContactTextboxes();
        }


        /*
         * Allows for the weight panel textboxes to be set
         * to blank after each computation is completed.
         */
        public void clearContactTextboxes()
        {
            docOfficeName_tbox.Text = "";
            docFirstName_tbox.Text = "";
            docLastName_tbox.Text = "";
            docAddress1_tbox.Text = "";
            docCity_tbox.Text = "";
            docState_tbox.Text = "";
            docZip_tbox.Text = "";
            docPhone_tbox.Text = "";
            docEmail_tbox.Text = "";
        }
        
        
        
        ///
        /// Measurements Panel
        ///
        
        
        /*
         * Allows for the measurements datatable to be called and then 
         * the data found there is then loaded into the Datatable in the
         * Measurements Panel. The first column is not visable in the 
         * table view itself.
         */
        public void measurementDataTable()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT ID, Length, Waist, Head, Chest, Hips FROM Measurements where BabyID = '" + babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    measurementDatatable.DataSource = dt;
                    this.measurementDatatable.Columns[0].Visible = false;
                    measurementChartMethod();
                }
            }
        }
        
        
        /*
         * Allows for the meaurements panel textboxes to be set
         * to blank after each computation is completed.
         */
        public void clearMeasurementTextboxes() 
        {
            measurementsLength_tbox.Text = "";
            measurementsWaist_tbox.Text = "";
            measurementsHead_tbox.Text = "";
            measurementsChest_tbox.Text = "";
            measurementsHips_tbox.Text = "";
        }
        
        
        /*
         * Allows for the data from the database to be displayed on all four
         * of the graphs shown in the Measurements panel. These data points
         * are used from the Measurements Table in the database.
         */
         public void measurementChartMethod()
        {
            string weightQuery = "SELECT * FROM Measurements WHERE BabyID = '"+babyName+"'";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(weightQuery, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                measurementsLengthChart.Series["Length"].Points.Clear();
                measurementsWaistChart.Series["Waist"].Points.Clear();
                measurementsHeadChart.Series["Head"].Points.Clear();
                measurementsChestChart.Series["Chest"].Points.Clear();
                
                while (reader.Read())
                {
                    measurementsLengthChart.Series["Length"].Points.AddXY(reader[0], reader[1]);
                    measurementsWaistChart.Series["Waist"].Points.AddXY(reader[0], reader[1]);
                    measurementsHeadChart.Series["Head"].Points.AddXY(reader[0], reader[1]);
                    measurementsChestChart.Series["Chest"].Points.AddXY(reader[0], reader[1]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error in loading Charts!" +ex);
            }
        }


        /*
         * When a row is clicked in the table in the panel, this allows for the information
         * from those cells selected in the row to be collected and then displayed in the
         * textboxs.
         */
        private void measurementDatatable_Click(object sender, EventArgs e)
        {
            measurementsID = Convert.ToInt32(measurementDatatable.CurrentRow.Cells[0].Value.ToString());
            measurementsLength_tbox.Text = measurementDatatable.CurrentRow.Cells[1].Value.ToString();
            measurementsWaist_tbox.Text = measurementDatatable.CurrentRow.Cells[2].Value.ToString();
            measurementsHead_tbox.Text = measurementDatatable.CurrentRow.Cells[3].Value.ToString();
            measurementsChest_tbox.Text = measurementDatatable.CurrentRow.Cells[4].Value.ToString();
            measurementsHips_tbox.Text = measurementDatatable.CurrentRow.Cells[5].Value.ToString();


        }


        /*
         * Allows for a new entry to be added to the measruements table on the
         * panel. This button converts the textbox values to strings and then
         * the string are then saved into the database table. All method to complete
         * this process are called from this buttons function.
         */
        private void newMeasurement_btn_Click(object sender, EventArgs e)
        {
            measurementsLength = measurementsLength_tbox.Text;
            measurementsWaist = measurementsWaist_tbox.Text;
            measurementsHead = measurementsHead_tbox.Text;
            measurementsChest = measurementsChest_tbox.Text;
            measurementsHips = measurementsHips_tbox.Text;
            measurementsClass.addMeasurements();
            measurementDataTable();
            measurementChartMethod();
            clearMeasurementTextboxes();
        }


        /*
         * Allows for an edit to be made on a record that has already been enter.
         * This follows the same procedure as entering a new record, but yet
         * it is just editing one.
         */
        private void measurementEdit_btn_Click(object sender, EventArgs e)
        {
            measurementsLength = measurementsLength_tbox.Text;
            measurementsWaist = measurementsWaist_tbox.Text;
            measurementsHead = measurementsHead_tbox.Text;
            measurementsChest = measurementsChest_tbox.Text;
            measurementsHips = measurementsHips_tbox.Text;
            measurementsClass.updateMeasurements();
            measurementDataTable();
            measurementChartMethod();
            clearMeasurementTextboxes();
        }

    
        /*
         * Allows for a record to be deleted from the datbase and also allows
         * for all charts and table views to refreshed to display the edit 
         * to the table.
         */
        private void measurementsDelete_btn_Click(object sender, EventArgs e)
        {
            measurementsClass.deleteMeasurements();
            measurementDataTable();
            measurementChartMethod();
            clearMeasurementTextboxes();
        }
    }
}
