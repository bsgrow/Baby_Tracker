using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Tracker
{
    public partial class WeightEntryForm : Form
    {

        Weight weightClass = new Weight();

        //String declarations
        public static double weightEntry = 0;
        public static string dateEntry = "";

        public WeightEntryForm()
        {
            InitializeComponent();
        }

        /*
         * When presed this Hides the panel and no entry is recored
         * Also, the textboxes are cleared just incase the user 
         * may have typed in them.
         */
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            clearTextBoxes();
        }


        /*
         * Once pressed the information from the textboxes are converted to a
         * string value, then sent to the Weight Class to be added to the 
         * database. Then the form is hidden and the datbase table is then
         * called again to rest the table after an entry into the table.
         */
        private void saveWeight_btn_Click(object sender, EventArgs e)
        {
            BabyTracker babyTracker = new BabyTracker();
            weightEntry = double.Parse(weight_txbox.Text);
            dateEntry = date_txBox.Text;
            weightClass.addWeight();
            Hide();
            babyTracker.dataTable();
            clearTextBoxes();
        }


        /*
         * Allows for the textboxes to be cleared. This method 
         * is called in both the cancel and save fearture of
         * the WeightEntryForm.
         */
        public void clearTextBoxes()
        {
            weight_txbox.Text = "";
            date_txBox.Text = "";
        }
    }
}
