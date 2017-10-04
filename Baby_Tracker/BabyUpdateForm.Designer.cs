namespace Baby_Tracker
{
    partial class BabyUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyUpdateForm));
            this.updateBabyEntryTitle_lb = new System.Windows.Forms.Label();
            this.updateCancel_btn = new System.Windows.Forms.Button();
            this.updateEntry_btn = new System.Windows.Forms.Button();
            this.updatePathLocation_lb = new System.Windows.Forms.Label();
            this.updateCombo = new System.Windows.Forms.ComboBox();
            this.profilePic_lb = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.profilePic_comb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBabyEntryTitle_lb
            // 
            this.updateBabyEntryTitle_lb.AutoSize = true;
            this.updateBabyEntryTitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBabyEntryTitle_lb.Location = new System.Drawing.Point(79, 9);
            this.updateBabyEntryTitle_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateBabyEntryTitle_lb.Name = "updateBabyEntryTitle_lb";
            this.updateBabyEntryTitle_lb.Size = new System.Drawing.Size(241, 29);
            this.updateBabyEntryTitle_lb.TabIndex = 1;
            this.updateBabyEntryTitle_lb.Text = "Update Baby Image";
            // 
            // updateCancel_btn
            // 
            this.updateCancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCancel_btn.Location = new System.Drawing.Point(222, 229);
            this.updateCancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.updateCancel_btn.Name = "updateCancel_btn";
            this.updateCancel_btn.Size = new System.Drawing.Size(119, 26);
            this.updateCancel_btn.TabIndex = 13;
            this.updateCancel_btn.Text = "Cancel";
            this.updateCancel_btn.UseVisualStyleBackColor = true;
            this.updateCancel_btn.Click += new System.EventHandler(this.updateCancel_btn_Click);
            // 
            // updateEntry_btn
            // 
            this.updateEntry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEntry_btn.Location = new System.Drawing.Point(46, 229);
            this.updateEntry_btn.Margin = new System.Windows.Forms.Padding(2);
            this.updateEntry_btn.Name = "updateEntry_btn";
            this.updateEntry_btn.Size = new System.Drawing.Size(139, 26);
            this.updateEntry_btn.TabIndex = 12;
            this.updateEntry_btn.Text = "Update Baby Entry";
            this.updateEntry_btn.UseVisualStyleBackColor = true;
            this.updateEntry_btn.Click += new System.EventHandler(this.updateEntry_btn_Click);
            // 
            // updatePathLocation_lb
            // 
            this.updatePathLocation_lb.AutoSize = true;
            this.updatePathLocation_lb.Location = new System.Drawing.Point(122, 406);
            this.updatePathLocation_lb.Name = "updatePathLocation_lb";
            this.updatePathLocation_lb.Size = new System.Drawing.Size(0, 13);
            this.updatePathLocation_lb.TabIndex = 21;
            // 
            // updateCombo
            // 
            this.updateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateCombo.FormattingEnabled = true;
            this.updateCombo.Location = new System.Drawing.Point(142, 54);
            this.updateCombo.Margin = new System.Windows.Forms.Padding(2);
            this.updateCombo.Name = "updateCombo";
            this.updateCombo.Size = new System.Drawing.Size(92, 21);
            this.updateCombo.TabIndex = 22;
            // 
            // profilePic_lb
            // 
            this.profilePic_lb.AutoSize = true;
            this.profilePic_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePic_lb.Location = new System.Drawing.Point(11, 132);
            this.profilePic_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profilePic_lb.Name = "profilePic_lb";
            this.profilePic_lb.Size = new System.Drawing.Size(82, 20);
            this.profilePic_lb.TabIndex = 26;
            this.profilePic_lb.Text = "Profile Pic:";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(109, 109);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(60, 65);
            this.profilePictureBox.TabIndex = 25;
            this.profilePictureBox.TabStop = false;
            // 
            // profilePic_comb
            // 
            this.profilePic_comb.FormattingEnabled = true;
            this.profilePic_comb.Location = new System.Drawing.Point(204, 134);
            this.profilePic_comb.Margin = new System.Windows.Forms.Padding(2);
            this.profilePic_comb.Name = "profilePic_comb";
            this.profilePic_comb.Size = new System.Drawing.Size(162, 21);
            this.profilePic_comb.TabIndex = 24;
            this.profilePic_comb.SelectedIndexChanged += new System.EventHandler(this.profilePic_comb_SelectedIndexChanged);
            // 
            // BabyUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.ControlBox = false;
            this.Controls.Add(this.profilePic_lb);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.profilePic_comb);
            this.Controls.Add(this.updateCombo);
            this.Controls.Add(this.updatePathLocation_lb);
            this.Controls.Add(this.updateCancel_btn);
            this.Controls.Add(this.updateEntry_btn);
            this.Controls.Add(this.updateBabyEntryTitle_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BabyUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Update Form";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateBabyEntryTitle_lb;
        private System.Windows.Forms.Button updateCancel_btn;
        private System.Windows.Forms.Button updateEntry_btn;
        private System.Windows.Forms.Label updatePathLocation_lb;
        private System.Windows.Forms.ComboBox updateCombo;
        private System.Windows.Forms.Label profilePic_lb;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.ComboBox profilePic_comb;
    }
}