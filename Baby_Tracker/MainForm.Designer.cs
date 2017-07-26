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
            this.medications_btn = new System.Windows.Forms.Button();
            this.weight_btn = new System.Windows.Forms.Button();
            this.growthStat_btn = new System.Windows.Forms.Button();
            this.doctorContact_btn = new System.Windows.Forms.Button();
            this.appointment_btn = new System.Windows.Forms.Button();
            this.immunizations_btn = new System.Windows.Forms.Button();
            this.measurements_btn = new System.Windows.Forms.Button();
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
            this.dashBoardPanel_lb = new System.Windows.Forms.Label();
            this.testPanel = new System.Windows.Forms.Panel();
            this.deleteWeight_btn = new System.Windows.Forms.Button();
            this.weightEntry_btn = new System.Windows.Forms.Button();
            this.weightTableView = new System.Windows.Forms.DataGridView();
            this.weightPanel_lb = new System.Windows.Forms.Label();
            this.measurementsPanel = new System.Windows.Forms.Panel();
            this.measurementsPanel_lb = new System.Windows.Forms.Label();
            this.immunizationsPanel = new System.Windows.Forms.Panel();
            this.immunizationsPanel_lb = new System.Windows.Forms.Label();
            this.medicationsPanel = new System.Windows.Forms.Panel();
            this.medicationPanel_lb = new System.Windows.Forms.Label();
            this.appointmentsPanel = new System.Windows.Forms.Panel();
            this.appointmentsPanel_lb = new System.Windows.Forms.Label();
            this.doctorContactsPanel = new System.Windows.Forms.Panel();
            this.doctorContactsPanel_lb = new System.Windows.Forms.Label();
            this.growthStatsPanel = new System.Windows.Forms.Panel();
            this.growthStatPanel_lb = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_box)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTableView)).BeginInit();
            this.measurementsPanel.SuspendLayout();
            this.immunizationsPanel.SuspendLayout();
            this.medicationsPanel.SuspendLayout();
            this.appointmentsPanel.SuspendLayout();
            this.doctorContactsPanel.SuspendLayout();
            this.growthStatsPanel.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.medications_btn);
            this.leftPanel.Controls.Add(this.weight_btn);
            this.leftPanel.Controls.Add(this.growthStat_btn);
            this.leftPanel.Controls.Add(this.doctorContact_btn);
            this.leftPanel.Controls.Add(this.appointment_btn);
            this.leftPanel.Controls.Add(this.immunizations_btn);
            this.leftPanel.Controls.Add(this.measurements_btn);
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
            // medications_btn
            // 
            this.medications_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medications_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medications_btn.Image = global::Baby_Tracker.Properties.Resources.medicationIcon;
            this.medications_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medications_btn.Location = new System.Drawing.Point(17, 555);
            this.medications_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medications_btn.Name = "medications_btn";
            this.medications_btn.Size = new System.Drawing.Size(235, 62);
            this.medications_btn.TabIndex = 16;
            this.medications_btn.Text = "Medications";
            this.medications_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medications_btn.UseVisualStyleBackColor = true;
            this.medications_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // weight_btn
            // 
            this.weight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_btn.Image = global::Baby_Tracker.Properties.Resources.weightIcon;
            this.weight_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weight_btn.Location = new System.Drawing.Point(17, 342);
            this.weight_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weight_btn.Name = "weight_btn";
            this.weight_btn.Size = new System.Drawing.Size(235, 62);
            this.weight_btn.TabIndex = 15;
            this.weight_btn.Text = "Weight";
            this.weight_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_btn.UseVisualStyleBackColor = true;
            this.weight_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // growthStat_btn
            // 
            this.growthStat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.growthStat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.growthStat_btn.Image = global::Baby_Tracker.Properties.Resources.statIcon;
            this.growthStat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.growthStat_btn.Location = new System.Drawing.Point(17, 769);
            this.growthStat_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.growthStat_btn.Name = "growthStat_btn";
            this.growthStat_btn.Size = new System.Drawing.Size(235, 62);
            this.growthStat_btn.TabIndex = 14;
            this.growthStat_btn.Text = "Growth Stats";
            this.growthStat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.growthStat_btn.UseVisualStyleBackColor = true;
            this.growthStat_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // doctorContact_btn
            // 
            this.doctorContact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorContact_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorContact_btn.Image = global::Baby_Tracker.Properties.Resources.contactIcon;
            this.doctorContact_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorContact_btn.Location = new System.Drawing.Point(17, 697);
            this.doctorContact_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorContact_btn.Name = "doctorContact_btn";
            this.doctorContact_btn.Size = new System.Drawing.Size(235, 62);
            this.doctorContact_btn.TabIndex = 13;
            this.doctorContact_btn.Text = "Doctor Contacts";
            this.doctorContact_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doctorContact_btn.UseVisualStyleBackColor = true;
            this.doctorContact_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // appointment_btn
            // 
            this.appointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointment_btn.Image = global::Baby_Tracker.Properties.Resources.calanderIcon;
            this.appointment_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointment_btn.Location = new System.Drawing.Point(17, 626);
            this.appointment_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointment_btn.Name = "appointment_btn";
            this.appointment_btn.Size = new System.Drawing.Size(235, 62);
            this.appointment_btn.TabIndex = 12;
            this.appointment_btn.Text = "Appointments";
            this.appointment_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointment_btn.UseVisualStyleBackColor = true;
            this.appointment_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // immunizations_btn
            // 
            this.immunizations_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.immunizations_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.immunizations_btn.Image = global::Baby_Tracker.Properties.Resources.immunizationIcon;
            this.immunizations_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.immunizations_btn.Location = new System.Drawing.Point(17, 484);
            this.immunizations_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.immunizations_btn.Name = "immunizations_btn";
            this.immunizations_btn.Size = new System.Drawing.Size(235, 62);
            this.immunizations_btn.TabIndex = 11;
            this.immunizations_btn.Text = "Immunizations";
            this.immunizations_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.immunizations_btn.UseVisualStyleBackColor = true;
            this.immunizations_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // measurements_btn
            // 
            this.measurements_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.measurements_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurements_btn.Image = global::Baby_Tracker.Properties.Resources.measurementsIcon;
            this.measurements_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.measurements_btn.Location = new System.Drawing.Point(17, 414);
            this.measurements_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.measurements_btn.Name = "measurements_btn";
            this.measurements_btn.Size = new System.Drawing.Size(235, 62);
            this.measurements_btn.TabIndex = 10;
            this.measurements_btn.Text = "Measurements";
            this.measurements_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.measurements_btn.UseVisualStyleBackColor = true;
            this.measurements_btn.Click += new System.EventHandler(this.button1_Click);
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
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
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
            this.dashboardPanel.Controls.Add(this.dashBoardPanel_lb);
            this.dashboardPanel.Location = new System.Drawing.Point(277, 31);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1298, 918);
            this.dashboardPanel.TabIndex = 2;
            // 
            // dashBoardPanel_lb
            // 
            this.dashBoardPanel_lb.AutoSize = true;
            this.dashBoardPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardPanel_lb.Location = new System.Drawing.Point(525, 15);
            this.dashBoardPanel_lb.Name = "dashBoardPanel_lb";
            this.dashBoardPanel_lb.Size = new System.Drawing.Size(242, 51);
            this.dashBoardPanel_lb.TabIndex = 1;
            this.dashBoardPanel_lb.Text = "Dashboard";
            // 
            // testPanel
            // 
            this.testPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testPanel.Controls.Add(this.deleteWeight_btn);
            this.testPanel.Controls.Add(this.weightEntry_btn);
            this.testPanel.Controls.Add(this.weightTableView);
            this.testPanel.Controls.Add(this.weightPanel_lb);
            this.testPanel.Location = new System.Drawing.Point(277, 31);
            this.testPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(1298, 918);
            this.testPanel.TabIndex = 0;
            // 
            // deleteWeight_btn
            // 
            this.deleteWeight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWeight_btn.Location = new System.Drawing.Point(1028, 639);
            this.deleteWeight_btn.Name = "deleteWeight_btn";
            this.deleteWeight_btn.Size = new System.Drawing.Size(180, 38);
            this.deleteWeight_btn.TabIndex = 11;
            this.deleteWeight_btn.Text = "Delete Weight Entry";
            this.deleteWeight_btn.UseVisualStyleBackColor = true;
            // 
            // weightEntry_btn
            // 
            this.weightEntry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightEntry_btn.Location = new System.Drawing.Point(779, 639);
            this.weightEntry_btn.Name = "weightEntry_btn";
            this.weightEntry_btn.Size = new System.Drawing.Size(180, 38);
            this.weightEntry_btn.TabIndex = 10;
            this.weightEntry_btn.Text = "New Weight Entry";
            this.weightEntry_btn.UseVisualStyleBackColor = true;
            this.weightEntry_btn.Click += new System.EventHandler(this.weightEntry_btn_Click);
            // 
            // weightTableView
            // 
            this.weightTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weightTableView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightTableView.Location = new System.Drawing.Point(727, 86);
            this.weightTableView.Name = "weightTableView";
            this.weightTableView.RowTemplate.Height = 24;
            this.weightTableView.Size = new System.Drawing.Size(527, 531);
            this.weightTableView.TabIndex = 9;
            // 
            // weightPanel_lb
            // 
            this.weightPanel_lb.AutoSize = true;
            this.weightPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightPanel_lb.Location = new System.Drawing.Point(563, 3);
            this.weightPanel_lb.Name = "weightPanel_lb";
            this.weightPanel_lb.Size = new System.Drawing.Size(163, 51);
            this.weightPanel_lb.TabIndex = 0;
            this.weightPanel_lb.Text = "Weight";
            // 
            // measurementsPanel
            // 
            this.measurementsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.measurementsPanel.Controls.Add(this.measurementsPanel_lb);
            this.measurementsPanel.Location = new System.Drawing.Point(277, 31);
            this.measurementsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.measurementsPanel.Name = "measurementsPanel";
            this.measurementsPanel.Size = new System.Drawing.Size(1298, 918);
            this.measurementsPanel.TabIndex = 1;
            // 
            // measurementsPanel_lb
            // 
            this.measurementsPanel_lb.AutoSize = true;
            this.measurementsPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementsPanel_lb.Location = new System.Drawing.Point(440, 17);
            this.measurementsPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.measurementsPanel_lb.Name = "measurementsPanel_lb";
            this.measurementsPanel_lb.Size = new System.Drawing.Size(324, 52);
            this.measurementsPanel_lb.TabIndex = 0;
            this.measurementsPanel_lb.Text = "Measurements";
            // 
            // immunizationsPanel
            // 
            this.immunizationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.immunizationsPanel.Controls.Add(this.immunizationsPanel_lb);
            this.immunizationsPanel.Location = new System.Drawing.Point(277, 31);
            this.immunizationsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.immunizationsPanel.Name = "immunizationsPanel";
            this.immunizationsPanel.Size = new System.Drawing.Size(1298, 918);
            this.immunizationsPanel.TabIndex = 1;
            // 
            // immunizationsPanel_lb
            // 
            this.immunizationsPanel_lb.AutoSize = true;
            this.immunizationsPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.immunizationsPanel_lb.Location = new System.Drawing.Point(445, 17);
            this.immunizationsPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.immunizationsPanel_lb.Name = "immunizationsPanel_lb";
            this.immunizationsPanel_lb.Size = new System.Drawing.Size(318, 52);
            this.immunizationsPanel_lb.TabIndex = 0;
            this.immunizationsPanel_lb.Text = "Immunizations";
            // 
            // medicationsPanel
            // 
            this.medicationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicationsPanel.Controls.Add(this.medicationPanel_lb);
            this.medicationsPanel.Location = new System.Drawing.Point(277, 31);
            this.medicationsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.medicationsPanel.Name = "medicationsPanel";
            this.medicationsPanel.Size = new System.Drawing.Size(1298, 918);
            this.medicationsPanel.TabIndex = 1;
            // 
            // medicationPanel_lb
            // 
            this.medicationPanel_lb.AutoSize = true;
            this.medicationPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationPanel_lb.Location = new System.Drawing.Point(448, 17);
            this.medicationPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicationPanel_lb.Name = "medicationPanel_lb";
            this.medicationPanel_lb.Size = new System.Drawing.Size(267, 52);
            this.medicationPanel_lb.TabIndex = 0;
            this.medicationPanel_lb.Text = "Medications";
            // 
            // appointmentsPanel
            // 
            this.appointmentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentsPanel.Controls.Add(this.appointmentsPanel_lb);
            this.appointmentsPanel.Location = new System.Drawing.Point(277, 31);
            this.appointmentsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsPanel.Name = "appointmentsPanel";
            this.appointmentsPanel.Size = new System.Drawing.Size(1298, 918);
            this.appointmentsPanel.TabIndex = 1;
            // 
            // appointmentsPanel_lb
            // 
            this.appointmentsPanel_lb.AutoSize = true;
            this.appointmentsPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsPanel_lb.Location = new System.Drawing.Point(448, 17);
            this.appointmentsPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointmentsPanel_lb.Name = "appointmentsPanel_lb";
            this.appointmentsPanel_lb.Size = new System.Drawing.Size(301, 52);
            this.appointmentsPanel_lb.TabIndex = 0;
            this.appointmentsPanel_lb.Text = "Appointments";
            // 
            // doctorContactsPanel
            // 
            this.doctorContactsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorContactsPanel.Controls.Add(this.doctorContactsPanel_lb);
            this.doctorContactsPanel.Location = new System.Drawing.Point(277, 31);
            this.doctorContactsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.doctorContactsPanel.Name = "doctorContactsPanel";
            this.doctorContactsPanel.Size = new System.Drawing.Size(1298, 918);
            this.doctorContactsPanel.TabIndex = 1;
            // 
            // doctorContactsPanel_lb
            // 
            this.doctorContactsPanel_lb.AutoSize = true;
            this.doctorContactsPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorContactsPanel_lb.Location = new System.Drawing.Point(411, 16);
            this.doctorContactsPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorContactsPanel_lb.Name = "doctorContactsPanel_lb";
            this.doctorContactsPanel_lb.Size = new System.Drawing.Size(351, 52);
            this.doctorContactsPanel_lb.TabIndex = 0;
            this.doctorContactsPanel_lb.Text = "Doctor Contacts";
            // 
            // growthStatsPanel
            // 
            this.growthStatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.growthStatsPanel.Controls.Add(this.growthStatPanel_lb);
            this.growthStatsPanel.Location = new System.Drawing.Point(277, 31);
            this.growthStatsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.growthStatsPanel.Name = "growthStatsPanel";
            this.growthStatsPanel.Size = new System.Drawing.Size(1298, 918);
            this.growthStatsPanel.TabIndex = 1;
            // 
            // growthStatPanel_lb
            // 
            this.growthStatPanel_lb.AutoSize = true;
            this.growthStatPanel_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.growthStatPanel_lb.Location = new System.Drawing.Point(411, 17);
            this.growthStatPanel_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.growthStatPanel_lb.Name = "growthStatPanel_lb";
            this.growthStatPanel_lb.Size = new System.Drawing.Size(368, 52);
            this.growthStatPanel_lb.TabIndex = 0;
            this.growthStatPanel_lb.Text = "Growth Statistics";
            // 
            // BabyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 953);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.medicationsPanel);
            this.Controls.Add(this.immunizationsPanel);
            this.Controls.Add(this.growthStatsPanel);
            this.Controls.Add(this.doctorContactsPanel);
            this.Controls.Add(this.appointmentsPanel);
            this.Controls.Add(this.measurementsPanel);
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
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightTableView)).EndInit();
            this.measurementsPanel.ResumeLayout(false);
            this.measurementsPanel.PerformLayout();
            this.immunizationsPanel.ResumeLayout(false);
            this.immunizationsPanel.PerformLayout();
            this.medicationsPanel.ResumeLayout(false);
            this.medicationsPanel.PerformLayout();
            this.appointmentsPanel.ResumeLayout(false);
            this.appointmentsPanel.PerformLayout();
            this.doctorContactsPanel.ResumeLayout(false);
            this.doctorContactsPanel.PerformLayout();
            this.growthStatsPanel.ResumeLayout(false);
            this.growthStatsPanel.PerformLayout();
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
        private System.Windows.Forms.Button medications_btn;
        private System.Windows.Forms.Button weight_btn;
        private System.Windows.Forms.Button growthStat_btn;
        private System.Windows.Forms.Button doctorContact_btn;
        private System.Windows.Forms.Button appointment_btn;
        private System.Windows.Forms.Button immunizations_btn;
        private System.Windows.Forms.Button measurements_btn;
        private System.Windows.Forms.ToolStripMenuItem babyListExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babyListPDFToolStripMenuItem;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Label dashBoardPanel_lb;
        private System.Windows.Forms.Label weightPanel_lb;
        private System.Windows.Forms.Panel measurementsPanel;
        private System.Windows.Forms.Label measurementsPanel_lb;
        private System.Windows.Forms.Panel immunizationsPanel;
        private System.Windows.Forms.Label immunizationsPanel_lb;
        private System.Windows.Forms.Panel medicationsPanel;
        private System.Windows.Forms.Label medicationPanel_lb;
        private System.Windows.Forms.Panel appointmentsPanel;
        private System.Windows.Forms.Label appointmentsPanel_lb;
        private System.Windows.Forms.Panel doctorContactsPanel;
        private System.Windows.Forms.Label doctorContactsPanel_lb;
        private System.Windows.Forms.Panel growthStatsPanel;
        private System.Windows.Forms.Label growthStatPanel_lb;
        public static System.Windows.Forms.DataGridView weightGridView;
        private System.Windows.Forms.DataGridView weightTableView;
        private System.Windows.Forms.Button deleteWeight_btn;
        private System.Windows.Forms.Button weightEntry_btn;
    }
}

