namespace Manager.Views
{
    partial class FinanceStatusViewForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFinancialStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSelectedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "My Financial Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 68);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(150, 118);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelSelectedDate);
            this.panel1.Controls.Add(this.labelFinancialStatus);
            this.panel1.Location = new System.Drawing.Point(104, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 75);
            this.panel1.TabIndex = 13;
            // 
            // labelFinancialStatus
            // 
            this.labelFinancialStatus.AutoSize = true;
            this.labelFinancialStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinancialStatus.Location = new System.Drawing.Point(3, 31);
            this.labelFinancialStatus.Name = "labelFinancialStatus";
            this.labelFinancialStatus.Size = new System.Drawing.Size(347, 23);
            this.labelFinancialStatus.TabIndex = 0;
            this.labelFinancialStatus.Text = "Click on the date to view financial status";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Manager.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(17, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // labelSelectedDate
            // 
            this.labelSelectedDate.AutoSize = true;
            this.labelSelectedDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedDate.Location = new System.Drawing.Point(3, 8);
            this.labelSelectedDate.Name = "labelSelectedDate";
            this.labelSelectedDate.Size = new System.Drawing.Size(75, 23);
            this.labelSelectedDate.TabIndex = 1;
            this.labelSelectedDate.Text = "<Date>";
            // 
            // FinanceStatusViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 393);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FinanceStatusViewForm";
            this.Text = "FinanceStatusViewForm";
            this.Load += new System.EventHandler(this.FinanceStatusViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFinancialStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSelectedDate;
    }
}