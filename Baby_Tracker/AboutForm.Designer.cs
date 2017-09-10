namespace Baby_Tracker
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutWelcome_lb = new System.Windows.Forms.Label();
            this.aboutCreatedBy_lb = new System.Windows.Forms.Label();
            this.aboutOK_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutWelcome_lb
            // 
            this.aboutWelcome_lb.AutoSize = true;
            this.aboutWelcome_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutWelcome_lb.Location = new System.Drawing.Point(28, 19);
            this.aboutWelcome_lb.Name = "aboutWelcome_lb";
            this.aboutWelcome_lb.Size = new System.Drawing.Size(325, 18);
            this.aboutWelcome_lb.TabIndex = 0;
            this.aboutWelcome_lb.Text = "Welcome to the Baby Tacker Application!!!\r\n";
            // 
            // aboutCreatedBy_lb
            // 
            this.aboutCreatedBy_lb.AutoSize = true;
            this.aboutCreatedBy_lb.Location = new System.Drawing.Point(54, 59);
            this.aboutCreatedBy_lb.Name = "aboutCreatedBy_lb";
            this.aboutCreatedBy_lb.Size = new System.Drawing.Size(273, 156);
            this.aboutCreatedBy_lb.TabIndex = 1;
            this.aboutCreatedBy_lb.Text = resources.GetString("aboutCreatedBy_lb.Text");
            // 
            // aboutOK_btn
            // 
            this.aboutOK_btn.Location = new System.Drawing.Point(145, 236);
            this.aboutOK_btn.Name = "aboutOK_btn";
            this.aboutOK_btn.Size = new System.Drawing.Size(75, 23);
            this.aboutOK_btn.TabIndex = 2;
            this.aboutOK_btn.Text = "OK!";
            this.aboutOK_btn.UseVisualStyleBackColor = true;
            this.aboutOK_btn.Click += new System.EventHandler(this.aboutOK_btn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 271);
            this.ControlBox = false;
            this.Controls.Add(this.aboutOK_btn);
            this.Controls.Add(this.aboutCreatedBy_lb);
            this.Controls.Add(this.aboutWelcome_lb);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Tracker About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutWelcome_lb;
        private System.Windows.Forms.Label aboutCreatedBy_lb;
        private System.Windows.Forms.Button aboutOK_btn;
    }
}