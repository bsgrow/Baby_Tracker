namespace Baby_Tracker
{
    partial class BabyTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyTracker));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babyListExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babyListPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growthStatisticReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immunizationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.editBaby_btn = new System.Windows.Forms.Button();
            this.deleteBaby_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.name_lb = new System.Windows.Forms.Label();
            this.babyText_lb = new System.Windows.Forms.Label();
            this.userImage_box = new System.Windows.Forms.PictureBox();
            this.babySelector_cmbo = new System.Windows.Forms.ComboBox();
            this.leftPanelTitle_lb = new System.Windows.Forms.Label();
            this.newBaby_btn = new System.Windows.Forms.Button();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_box)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1581, 28);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Baby_Tracker.Properties.Resources.exitIcon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeReportToolStripMenuItem,
            this.weightReportToolStripMenuItem,
            this.growthStatisticReportToolStripMenuItem,
            this.immunizationReportToolStripMenuItem,
            this.contactListToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // completeReportToolStripMenuItem
            // 
            this.completeReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.babyListExcelToolStripMenuItem,
            this.babyListPDFToolStripMenuItem});
            this.completeReportToolStripMenuItem.Name = "completeReportToolStripMenuItem";
            this.completeReportToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.completeReportToolStripMenuItem.Text = "Baby List Report";
            // 
            // babyListExcelToolStripMenuItem
            // 
            this.babyListExcelToolStripMenuItem.Name = "babyListExcelToolStripMenuItem";
            this.babyListExcelToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.babyListExcelToolStripMenuItem.Text = "Baby List Excel";
            this.babyListExcelToolStripMenuItem.Click += new System.EventHandler(this.babyListExcelToolStripMenuItem_Click);
            // 
            // babyListPDFToolStripMenuItem
            // 
            this.babyListPDFToolStripMenuItem.Name = "babyListPDFToolStripMenuItem";
            this.babyListPDFToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.babyListPDFToolStripMenuItem.Text = "Baby List PDF";
            this.babyListPDFToolStripMenuItem.Click += new System.EventHandler(this.babyListPDFToolStripMenuItem_Click);
            // 
            // weightReportToolStripMenuItem
            // 
            this.weightReportToolStripMenuItem.Name = "weightReportToolStripMenuItem";
            this.weightReportToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.weightReportToolStripMenuItem.Text = "Weight Report";
            // 
            // growthStatisticReportToolStripMenuItem
            // 
            this.growthStatisticReportToolStripMenuItem.Name = "growthStatisticReportToolStripMenuItem";
            this.growthStatisticReportToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.growthStatisticReportToolStripMenuItem.Text = "Growth Statistic Report";
            // 
            // immunizationReportToolStripMenuItem
            // 
            this.immunizationReportToolStripMenuItem.Name = "immunizationReportToolStripMenuItem";
            this.immunizationReportToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.immunizationReportToolStripMenuItem.Text = "Immunization Report";
            // 
            // contactListToolStripMenuItem
            // 
            this.contactListToolStripMenuItem.Name = "contactListToolStripMenuItem";
            this.contactListToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.contactListToolStripMenuItem.Text = "Doctor Contact List";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDocumentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpDocumentationToolStripMenuItem
            // 
            this.helpDocumentationToolStripMenuItem.Image = global::Baby_Tracker.Properties.Resources.helpDocumIcon;
            this.helpDocumentationToolStripMenuItem.Name = "helpDocumentationToolStripMenuItem";
            this.helpDocumentationToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.helpDocumentationToolStripMenuItem.Text = "Help Documentation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Baby_Tracker.Properties.Resources.aboutIcon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.button7);
            this.leftPanel.Controls.Add(this.button6);
            this.leftPanel.Controls.Add(this.button5);
            this.leftPanel.Controls.Add(this.button4);
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.dashboard_btn);
            this.leftPanel.Controls.Add(this.editBaby_btn);
            this.leftPanel.Controls.Add(this.deleteBaby_btn);
            this.leftPanel.Controls.Add(this.settings_btn);
            this.leftPanel.Controls.Add(this.name_lb);
            this.leftPanel.Controls.Add(this.babyText_lb);
            this.leftPanel.Controls.Add(this.userImage_box);
            this.leftPanel.Controls.Add(this.babySelector_cmbo);
            this.leftPanel.Controls.Add(this.leftPanelTitle_lb);
            this.leftPanel.Controls.Add(this.newBaby_btn);
            this.leftPanel.Location = new System.Drawing.Point(5, 31);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(267, 918);
            this.leftPanel.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Baby_Tracker.Properties.Resources.medicationIcon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(17, 555);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 62);
            this.button7.TabIndex = 16;
            this.button7.Text = "Medications";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::Baby_Tracker.Properties.Resources.weightIcon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(17, 342);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 62);
            this.button6.TabIndex = 15;
            this.button6.Text = "Weight";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Baby_Tracker.Properties.Resources.statIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(17, 769);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 62);
            this.button5.TabIndex = 14;
            this.button5.Text = "Growth Stats";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Baby_Tracker.Properties.Resources.contactIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(17, 697);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 62);
            this.button4.TabIndex = 13;
            this.button4.Text = "Doctor Contacts";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Baby_Tracker.Properties.Resources.calanderIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(17, 626);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 62);
            this.button3.TabIndex = 12;
            this.button3.Text = "Appointments";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Baby_Tracker.Properties.Resources.immunizationIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(17, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 62);
            this.button2.TabIndex = 11;
            this.button2.Text = "Immunizations";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Baby_Tracker.Properties.Resources.measurementsIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Measurements";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Image = global::Baby_Tracker.Properties.Resources.dashboardIcon;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(17, 271);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(235, 62);
            this.dashboard_btn.TabIndex = 9;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_btn.UseVisualStyleBackColor = true;
            // 
            // editBaby_btn
            // 
            this.editBaby_btn.Image = global::Baby_Tracker.Properties.Resources.editIcon_L_;
            this.editBaby_btn.Location = new System.Drawing.Point(85, 873);
            this.editBaby_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBaby_btn.Name = "editBaby_btn";
            this.editBaby_btn.Size = new System.Drawing.Size(37, 38);
            this.editBaby_btn.TabIndex = 8;
            this.editBaby_btn.UseVisualStyleBackColor = true;
            this.editBaby_btn.Click += new System.EventHandler(this.editBaby_btn_Click);
            // 
            // deleteBaby_btn
            // 
            this.deleteBaby_btn.Image = global::Baby_Tracker.Properties.Resources.exportIcon;
            this.deleteBaby_btn.Location = new System.Drawing.Point(148, 873);
            this.deleteBaby_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBaby_btn.Name = "deleteBaby_btn";
            this.deleteBaby_btn.Size = new System.Drawing.Size(37, 38);
            this.deleteBaby_btn.TabIndex = 7;
            this.deleteBaby_btn.UseVisualStyleBackColor = true;
            this.deleteBaby_btn.Click += new System.EventHandler(this.deleteBaby_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Image = global::Baby_Tracker.Properties.Resources.settingsIcon_L_;
            this.settings_btn.Location = new System.Drawing.Point(211, 873);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(37, 38);
            this.settings_btn.TabIndex = 6;
            this.settings_btn.UseVisualStyleBackColor = true;
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.ForeColor = System.Drawing.Color.Blue;
            this.name_lb.Location = new System.Drawing.Point(117, 185);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(0, 25);
            this.name_lb.TabIndex = 4;
            // 
            // babyText_lb
            // 
            this.babyText_lb.AutoSize = true;
            this.babyText_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babyText_lb.Location = new System.Drawing.Point(107, 156);
            this.babyText_lb.Name = "babyText_lb";
            this.babyText_lb.Size = new System.Drawing.Size(67, 25);
            this.babyText_lb.TabIndex = 3;
            this.babyText_lb.Text = "Baby,";
            // 
            // userImage_box
            // 
            this.userImage_box.Location = new System.Drawing.Point(17, 156);
            this.userImage_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userImage_box.Name = "userImage_box";
            this.userImage_box.Size = new System.Drawing.Size(80, 80);
            this.userImage_box.TabIndex = 2;
            this.userImage_box.TabStop = false;
            // 
            // babySelector_cmbo
            // 
            this.babySelector_cmbo.AllowDrop = true;
            this.babySelector_cmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.babySelector_cmbo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.babySelector_cmbo.FormattingEnabled = true;
            this.babySelector_cmbo.Location = new System.Drawing.Point(43, 90);
            this.babySelector_cmbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.babySelector_cmbo.Name = "babySelector_cmbo";
            this.babySelector_cmbo.Size = new System.Drawing.Size(172, 24);
            this.babySelector_cmbo.TabIndex = 1;
            this.babySelector_cmbo.SelectedIndexChanged += new System.EventHandler(this.babySelector_cmbo_SelectedIndexChanged);
            // 
            // leftPanelTitle_lb
            // 
            this.leftPanelTitle_lb.AutoSize = true;
            this.leftPanelTitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanelTitle_lb.Location = new System.Drawing.Point(17, 15);
            this.leftPanelTitle_lb.Name = "leftPanelTitle_lb";
            this.leftPanelTitle_lb.Size = new System.Drawing.Size(225, 38);
            this.leftPanelTitle_lb.TabIndex = 0;
            this.leftPanelTitle_lb.Text = "Baby Tracker";
            // 
            // newBaby_btn
            // 
            this.newBaby_btn.Image = global::Baby_Tracker.Properties.Resources.addIcon;
            this.newBaby_btn.Location = new System.Drawing.Point(24, 873);
            this.newBaby_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBaby_btn.Name = "newBaby_btn";
            this.newBaby_btn.Size = new System.Drawing.Size(37, 38);
            this.newBaby_btn.TabIndex = 5;
            this.newBaby_btn.UseVisualStyleBackColor = true;
            this.newBaby_btn.Click += new System.EventHandler(this.newBaby_btn_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboardPanel.Location = new System.Drawing.Point(277, 31);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1298, 918);
            this.dashboardPanel.TabIndex = 2;
            // 
            // BabyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 952);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BabyTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Tracker";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem growthStatisticReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immunizationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label leftPanelTitle_lb;
        public System.Windows.Forms.ComboBox babySelector_cmbo;
        private System.Windows.Forms.Label babyText_lb;
        private System.Windows.Forms.PictureBox userImage_box;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button editBaby_btn;
        private System.Windows.Forms.Button deleteBaby_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button newBaby_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem babyListExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babyListPDFToolStripMenuItem;
    }
}

