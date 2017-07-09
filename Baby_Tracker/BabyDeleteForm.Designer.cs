namespace Baby_Tracker
{
    partial class BabyDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyDeleteForm));
            this.deleteBabyEntryTitle_lb = new System.Windows.Forms.Label();
            this.deleteBaby_cmbo = new System.Windows.Forms.ComboBox();
            this.deleteBaby_btn = new System.Windows.Forms.Button();
            this.textExplaination_text = new System.Windows.Forms.RichTextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteBabyEntryTitle_lb
            // 
            this.deleteBabyEntryTitle_lb.AutoSize = true;
            this.deleteBabyEntryTitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBabyEntryTitle_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBabyEntryTitle_lb.Location = new System.Drawing.Point(123, 24);
            this.deleteBabyEntryTitle_lb.Name = "deleteBabyEntryTitle_lb";
            this.deleteBabyEntryTitle_lb.Size = new System.Drawing.Size(270, 36);
            this.deleteBabyEntryTitle_lb.TabIndex = 2;
            this.deleteBabyEntryTitle_lb.Text = "Delete Baby Entry";
            // 
            // deleteBaby_cmbo
            // 
            this.deleteBaby_cmbo.FormattingEnabled = true;
            this.deleteBaby_cmbo.Location = new System.Drawing.Point(158, 82);
            this.deleteBaby_cmbo.Name = "deleteBaby_cmbo";
            this.deleteBaby_cmbo.Size = new System.Drawing.Size(205, 24);
            this.deleteBaby_cmbo.TabIndex = 3;
            this.deleteBaby_cmbo.SelectedIndexChanged += new System.EventHandler(this.deleteBaby_cmbo_SelectedIndexChanged);
            // 
            // deleteBaby_btn
            // 
            this.deleteBaby_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBaby_btn.Location = new System.Drawing.Point(92, 270);
            this.deleteBaby_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBaby_btn.Name = "deleteBaby_btn";
            this.deleteBaby_btn.Size = new System.Drawing.Size(185, 32);
            this.deleteBaby_btn.TabIndex = 13;
            this.deleteBaby_btn.Text = "Delete Baby Entry";
            this.deleteBaby_btn.UseVisualStyleBackColor = true;
            this.deleteBaby_btn.Click += new System.EventHandler(this.deleteBaby_btn_Click);
            // 
            // textExplaination_text
            // 
            this.textExplaination_text.Location = new System.Drawing.Point(82, 134);
            this.textExplaination_text.Name = "textExplaination_text";
            this.textExplaination_text.Size = new System.Drawing.Size(377, 107);
            this.textExplaination_text.TabIndex = 14;
            this.textExplaination_text.Text = "Delete a baby from this application will result in you losing all data entered. P" +
    "lease make sure that the correct baby is seleted in the drop down box. Once you " +
    "delete the baby all data will lost.";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(319, 270);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(114, 32);
            this.cancel_btn.TabIndex = 15;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // BabyDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.textExplaination_text);
            this.Controls.Add(this.deleteBaby_btn);
            this.Controls.Add(this.deleteBaby_cmbo);
            this.Controls.Add(this.deleteBabyEntryTitle_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BabyDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Delete ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteBabyEntryTitle_lb;
        private System.Windows.Forms.ComboBox deleteBaby_cmbo;
        private System.Windows.Forms.Button deleteBaby_btn;
        private System.Windows.Forms.RichTextBox textExplaination_text;
        private System.Windows.Forms.Button cancel_btn;
    }
}