namespace Baby_Tracker
{
    partial class WeightEntryForm
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
            this.weightForm_lb = new System.Windows.Forms.Label();
            this.weight_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.weight_txbox = new System.Windows.Forms.TextBox();
            this.date_txBox = new System.Windows.Forms.TextBox();
            this.saveWeight_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightForm_lb
            // 
            this.weightForm_lb.AutoSize = true;
            this.weightForm_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightForm_lb.Location = new System.Drawing.Point(90, 9);
            this.weightForm_lb.Name = "weightForm_lb";
            this.weightForm_lb.Size = new System.Drawing.Size(271, 36);
            this.weightForm_lb.TabIndex = 0;
            this.weightForm_lb.Text = "New Weight Entry";
            // 
            // weight_lb
            // 
            this.weight_lb.AutoSize = true;
            this.weight_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_lb.Location = new System.Drawing.Point(23, 95);
            this.weight_lb.Name = "weight_lb";
            this.weight_lb.Size = new System.Drawing.Size(75, 24);
            this.weight_lb.TabIndex = 1;
            this.weight_lb.Text = "Weight";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(23, 161);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(52, 24);
            this.date_lb.TabIndex = 2;
            this.date_lb.Text = "Date";
            // 
            // weight_txbox
            // 
            this.weight_txbox.Location = new System.Drawing.Point(105, 96);
            this.weight_txbox.Name = "weight_txbox";
            this.weight_txbox.Size = new System.Drawing.Size(265, 22);
            this.weight_txbox.TabIndex = 3;
            // 
            // date_txBox
            // 
            this.date_txBox.Location = new System.Drawing.Point(105, 163);
            this.date_txBox.Name = "date_txBox";
            this.date_txBox.Size = new System.Drawing.Size(265, 22);
            this.date_txBox.TabIndex = 4;
            // 
            // saveWeight_btn
            // 
            this.saveWeight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWeight_btn.Location = new System.Drawing.Point(72, 210);
            this.saveWeight_btn.Name = "saveWeight_btn";
            this.saveWeight_btn.Size = new System.Drawing.Size(123, 31);
            this.saveWeight_btn.TabIndex = 5;
            this.saveWeight_btn.Text = "Save Entry";
            this.saveWeight_btn.UseVisualStyleBackColor = true;
            this.saveWeight_btn.Click += new System.EventHandler(this.saveWeight_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(248, 210);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(86, 31);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // WeightEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 253);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.saveWeight_btn);
            this.Controls.Add(this.date_txBox);
            this.Controls.Add(this.weight_txbox);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.weight_lb);
            this.Controls.Add(this.weightForm_lb);
            this.Name = "WeightEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Weight Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightForm_lb;
        private System.Windows.Forms.Label weight_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.TextBox weight_txbox;
        private System.Windows.Forms.TextBox date_txBox;
        private System.Windows.Forms.Button saveWeight_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}