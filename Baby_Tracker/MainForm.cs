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
        BabyEntryForm babyEntryForm = new BabyEntryForm();
        BabyUpdateForm babyUpdateForm = new BabyUpdateForm();
        BabyDeleteForm babyDeleteForm = new BabyDeleteForm();
        ReportExports reportExports = new ReportExports();
        WeightEntryForm weightEntry = new WeightEntryForm();
        Weight weightClass = new Weight();

        public static string babyName = ""; //used thoughout the program to call the name selected by the user from combobox

        public BabyTracker()
        {
            InitializeComponent();
            comboBoxNameRetrival();
            dataTable();

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
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
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
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
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
                    dataTable();
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

        /*
         * Allows for the weightEntry panel to be shown. Here the
         * user will be able to entry a new weight for the user selected 
         * in the left panel combobox.
         */
        private void weightEntry_btn_Click(object sender, EventArgs e)
        {
            weightEntry.ShowDialog();
        }


        /*
         * Loads the weight gridviewtable in the weight panel. THis 
         * is queried based on the name selected from the combobox
         * on the left panel. This will change the weights based of
         * of that selection. 
         */
        public void dataTable()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source = BabyDatabase.sqlite; Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Weight, Date FROM Weight where BabyID = '" + babySelector_cmbo.GetItemText(babySelector_cmbo.SelectedItem) + "'", connection))
                {
                    dt.Clear();
                    da.Fill(dt);
                    weightTableView.DataSource = dt;
                }
            }
        }

        /*
         * Calls the addWeight from the Weight class. Here the information
         * from textboxes in the weightEntryForm are then recorded and 
         * saved into the database.
         */
        private void weightSubmit_btn_Click(object sender, EventArgs e)
        {
            weightClass.addWeight();
        }


    }
}
