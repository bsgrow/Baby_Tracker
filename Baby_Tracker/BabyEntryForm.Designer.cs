namespace Baby_Tracker
{
    partial class BabyEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyEntryForm));
            this.babyEntryTitle_lb = new System.Windows.Forms.Label();
            this.firstName_lb = new System.Windows.Forms.Label();
            this.lastName_lb = new System.Windows.Forms.Label();
            this.middleName_lb = new System.Windows.Forms.Label();
            this.dob_lb = new System.Windows.Forms.Label();
            this.birthWeight_lb = new System.Windows.Forms.Label();
            this.birthLength_lb = new System.Windows.Forms.Label();
            this.birthHeadCir_lb = new System.Windows.Forms.Label();
            this.middleName_tbox = new System.Windows.Forms.TextBox();
            this.firstName_tbox = new System.Windows.Forms.TextBox();
            this.lastName_tbox = new System.Windows.Forms.TextBox();
            this.dob_tbox = new System.Windows.Forms.TextBox();
            this.weight_tbox = new System.Windows.Forms.TextBox();
            this.length_tbox = new System.Windows.Forms.TextBox();
            this.head_tbox = new System.Windows.Forms.TextBox();
            this.addEntry_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pathLocation_lb = new System.Windows.Forms.Label();
            this.profilePic_comb = new System.Windows.Forms.ComboBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.profilePic_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // babyEntryTitle_lb
            // 
            this.babyEntryTitle_lb.AutoSize = true;
            this.babyEntryTitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babyEntryTitle_lb.Location = new System.Drawing.Point(157, 9);
            this.babyEntryTitle_lb.Name = "babyEntryTitle_lb";
            this.babyEntryTitle_lb.Size = new System.Drawing.Size(243, 36);
            this.babyEntryTitle_lb.TabIndex = 0;
            this.babyEntryTitle_lb.Text = "New Baby Entry";
            // 
            // firstName_lb
            // 
            this.firstName_lb.AutoSize = true;
            this.firstName_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lb.Location = new System.Drawing.Point(12, 78);
            this.firstName_lb.Name = "firstName_lb";
            this.firstName_lb.Size = new System.Drawing.Size(112, 25);
            this.firstName_lb.TabIndex = 1;
            this.firstName_lb.Text = "First Name:";
            // 
            // lastName_lb
            // 
            this.lastName_lb.AutoSize = true;
            this.lastName_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lb.Location = new System.Drawing.Point(12, 188);
            this.lastName_lb.Name = "lastName_lb";
            this.lastName_lb.Size = new System.Drawing.Size(112, 25);
            this.lastName_lb.TabIndex = 2;
            this.lastName_lb.Text = "Last Name:";
            // 
            // middleName_lb
            // 
            this.middleName_lb.AutoSize = true;
            this.middleName_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName_lb.Location = new System.Drawing.Point(12, 133);
            this.middleName_lb.Name = "middleName_lb";
            this.middleName_lb.Size = new System.Drawing.Size(133, 25);
            this.middleName_lb.TabIndex = 3;
            this.middleName_lb.Text = "Middle Name:";
            // 
            // dob_lb
            // 
            this.dob_lb.AutoSize = true;
            this.dob_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_lb.Location = new System.Drawing.Point(12, 242);
            this.dob_lb.Name = "dob_lb";
            this.dob_lb.Size = new System.Drawing.Size(61, 25);
            this.dob_lb.TabIndex = 4;
            this.dob_lb.Text = "DOB:";
            // 
            // birthWeight_lb
            // 
            this.birthWeight_lb.AutoSize = true;
            this.birthWeight_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthWeight_lb.Location = new System.Drawing.Point(12, 298);
            this.birthWeight_lb.Name = "birthWeight_lb";
            this.birthWeight_lb.Size = new System.Drawing.Size(124, 25);
            this.birthWeight_lb.TabIndex = 5;
            this.birthWeight_lb.Text = "Birth Weight:";
            // 
            // birthLength_lb
            // 
            this.birthLength_lb.AutoSize = true;
            this.birthLength_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLength_lb.Location = new System.Drawing.Point(12, 354);
            this.birthLength_lb.Name = "birthLength_lb";
            this.birthLength_lb.Size = new System.Drawing.Size(122, 25);
            this.birthLength_lb.TabIndex = 6;
            this.birthLength_lb.Text = "Birth Length:";
            // 
            // birthHeadCir_lb
            // 
            this.birthHeadCir_lb.AutoSize = true;
            this.birthHeadCir_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthHeadCir_lb.Location = new System.Drawing.Point(12, 410);
            this.birthHeadCir_lb.Name = "birthHeadCir_lb";
            this.birthHeadCir_lb.Size = new System.Drawing.Size(139, 25);
            this.birthHeadCir_lb.TabIndex = 7;
            this.birthHeadCir_lb.Text = "Birth Head Cir:";
            // 
            // middleName_tbox
            // 
            this.middleName_tbox.Location = new System.Drawing.Point(151, 135);
            this.middleName_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleName_tbox.Name = "middleName_tbox";
            this.middleName_tbox.Size = new System.Drawing.Size(369, 22);
            this.middleName_tbox.TabIndex = 1;
            // 
            // firstName_tbox
            // 
            this.firstName_tbox.Location = new System.Drawing.Point(152, 81);
            this.firstName_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName_tbox.Name = "firstName_tbox";
            this.firstName_tbox.Size = new System.Drawing.Size(369, 22);
            this.firstName_tbox.TabIndex = 0;
            // 
            // lastName_tbox
            // 
            this.lastName_tbox.Location = new System.Drawing.Point(151, 191);
            this.lastName_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName_tbox.Name = "lastName_tbox";
            this.lastName_tbox.Size = new System.Drawing.Size(369, 22);
            this.lastName_tbox.TabIndex = 2;
            // 
            // dob_tbox
            // 
            this.dob_tbox.Location = new System.Drawing.Point(152, 246);
            this.dob_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dob_tbox.Name = "dob_tbox";
            this.dob_tbox.Size = new System.Drawing.Size(369, 22);
            this.dob_tbox.TabIndex = 3;
            // 
            // weight_tbox
            // 
            this.weight_tbox.Location = new System.Drawing.Point(152, 302);
            this.weight_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weight_tbox.Name = "weight_tbox";
            this.weight_tbox.Size = new System.Drawing.Size(369, 22);
            this.weight_tbox.TabIndex = 4;
            // 
            // length_tbox
            // 
            this.length_tbox.Location = new System.Drawing.Point(152, 358);
            this.length_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.length_tbox.Name = "length_tbox";
            this.length_tbox.Size = new System.Drawing.Size(369, 22);
            this.length_tbox.TabIndex = 5;
            // 
            // head_tbox
            // 
            this.head_tbox.Location = new System.Drawing.Point(167, 414);
            this.head_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.head_tbox.Name = "head_tbox";
            this.head_tbox.Size = new System.Drawing.Size(355, 22);
            this.head_tbox.TabIndex = 6;
            // 
            // addEntry_btn
            // 
            this.addEntry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntry_btn.Location = new System.Drawing.Point(86, 591);
            this.addEntry_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEntry_btn.Name = "addEntry_btn";
            this.addEntry_btn.Size = new System.Drawing.Size(159, 32);
            this.addEntry_btn.TabIndex = 7;
            this.addEntry_btn.Text = "Add Baby Entry";
            this.addEntry_btn.UseVisualStyleBackColor = true;
            this.addEntry_btn.Click += new System.EventHandler(this.addEntry_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(288, 591);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(159, 32);
            this.cancel_btn.TabIndex = 8;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pathLocation_lb
            // 
            this.pathLocation_lb.AutoSize = true;
            this.pathLocation_lb.Location = new System.Drawing.Point(262, 559);
            this.pathLocation_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLocation_lb.Name = "pathLocation_lb";
            this.pathLocation_lb.Size = new System.Drawing.Size(0, 17);
            this.pathLocation_lb.TabIndex = 11;
            // 
            // profilePic_comb
            // 
            this.profilePic_comb.FormattingEnabled = true;
            this.profilePic_comb.Location = new System.Drawing.Point(265, 498);
            this.profilePic_comb.Name = "profilePic_comb";
            this.profilePic_comb.Size = new System.Drawing.Size(215, 24);
            this.profilePic_comb.TabIndex = 12;
            this.profilePic_comb.SelectedIndexChanged += new System.EventHandler(this.profilePic_comb_SelectedIndexChanged);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(152, 480);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(80, 80);
            this.profilePictureBox.TabIndex = 13;
            this.profilePictureBox.TabStop = false;
            // 
            // profilePic_lb
            // 
            this.profilePic_lb.AutoSize = true;
            this.profilePic_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePic_lb.Location = new System.Drawing.Point(12, 497);
            this.profilePic_lb.Name = "profilePic_lb";
            this.profilePic_lb.Size = new System.Drawing.Size(104, 25);
            this.profilePic_lb.TabIndex = 14;
            this.profilePic_lb.Text = "Profile Pic:";
            // 
            // BabyEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 637);
            this.ControlBox = false;
            this.Controls.Add(this.profilePic_lb);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.profilePic_comb);
            this.Controls.Add(this.pathLocation_lb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addEntry_btn);
            this.Controls.Add(this.head_tbox);
            this.Controls.Add(this.length_tbox);
            this.Controls.Add(this.weight_tbox);
            this.Controls.Add(this.dob_tbox);
            this.Controls.Add(this.lastName_tbox);
            this.Controls.Add(this.firstName_tbox);
            this.Controls.Add(this.middleName_tbox);
            this.Controls.Add(this.birthHeadCir_lb);
            this.Controls.Add(this.birthLength_lb);
            this.Controls.Add(this.birthWeight_lb);
            this.Controls.Add(this.dob_lb);
            this.Controls.Add(this.middleName_lb);
            this.Controls.Add(this.lastName_lb);
            this.Controls.Add(this.firstName_lb);
            this.Controls.Add(this.babyEntryTitle_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BabyEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Baby Entry ";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label babyEntryTitle_lb;
        private System.Windows.Forms.Label firstName_lb;
        private System.Windows.Forms.Label lastName_lb;
        private System.Windows.Forms.Label middleName_lb;
        private System.Windows.Forms.Label dob_lb;
        private System.Windows.Forms.Label birthWeight_lb;
        private System.Windows.Forms.Label birthLength_lb;
        private System.Windows.Forms.Label birthHeadCir_lb;
        private System.Windows.Forms.TextBox middleName_tbox;
        private System.Windows.Forms.TextBox firstName_tbox;
        private System.Windows.Forms.TextBox lastName_tbox;
        private System.Windows.Forms.TextBox dob_tbox;
        private System.Windows.Forms.TextBox weight_tbox;
        private System.Windows.Forms.TextBox length_tbox;
        private System.Windows.Forms.TextBox head_tbox;
        private System.Windows.Forms.Button addEntry_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label pathLocation_lb;
        private System.Windows.Forms.ComboBox profilePic_comb;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label profilePic_lb;
    }
}