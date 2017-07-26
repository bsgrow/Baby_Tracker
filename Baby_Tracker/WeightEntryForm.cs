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

        public static double weightEntry = 0;
        public static string dateEntry = "";

        public WeightEntryForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            clearTextBoxes();
        }

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

        public void clearTextBoxes()
        {
            weight_txbox.Text = "";
            date_txBox.Text = "";
        }
    }
}
