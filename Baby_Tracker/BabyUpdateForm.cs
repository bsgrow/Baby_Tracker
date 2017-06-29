using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        AddUpdateBaby addUpdateBaby = new AddUpdateBaby();


        public BabyUpdateForm()
        {
            InitializeComponent();
        }


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

        private void updateEntry_btn_Click(object sender, EventArgs e)
        {

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
    }
}
