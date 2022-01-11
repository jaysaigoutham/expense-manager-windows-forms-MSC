namespace Manager.Views
{
    partial class ReportView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExpense = new System.Windows.Forms.CheckBox();
            this.checkBoxIncome = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.buttonDownloadReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Finance Report ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenerateReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Controls.Add(this.checkBoxExpense);
            this.groupBox1.Controls.Add(this.checkBoxIncome);
            this.groupBox1.Location = new System.Drawing.Point(36, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(434, 72);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(237, 73);
            this.buttonGenerateReport.TabIndex = 7;
            this.buttonGenerateReport.Text = "Generate";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(176, 125);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(176, 79);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // checkBoxExpense
            // 
            this.checkBoxExpense.AutoSize = true;
            this.checkBoxExpense.Location = new System.Drawing.Point(176, 34);
            this.checkBoxExpense.Name = "checkBoxExpense";
            this.checkBoxExpense.Size = new System.Drawing.Size(67, 17);
            this.checkBoxExpense.TabIndex = 1;
            this.checkBoxExpense.Text = "Expense";
            this.checkBoxExpense.UseVisualStyleBackColor = true;
            this.checkBoxExpense.CheckedChanged += new System.EventHandler(this.checkBoxExpense_CheckedChanged);
            // 
            // checkBoxIncome
            // 
            this.checkBoxIncome.AutoSize = true;
            this.checkBoxIncome.Location = new System.Drawing.Point(48, 34);
            this.checkBoxIncome.Name = "checkBoxIncome";
            this.checkBoxIncome.Size = new System.Drawing.Size(61, 17);
            this.checkBoxIncome.TabIndex = 0;
            this.checkBoxIncome.Text = "Income";
            this.checkBoxIncome.UseVisualStyleBackColor = true;
            this.checkBoxIncome.CheckedChanged += new System.EventHandler(this.checkBoxIncome_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTotalExpense);
            this.groupBox2.Controls.Add(this.labelTotalIncome);
            this.groupBox2.Controls.Add(this.buttonDownloadReport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.listViewTransactions);
            this.groupBox2.Location = new System.Drawing.Point(36, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 188);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalExpense.Location = new System.Drawing.Point(172, 84);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(107, 20);
            this.labelTotalExpense.TabIndex = 15;
            this.labelTotalExpense.Text = "000000000 /=";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(172, 39);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(107, 20);
            this.labelTotalIncome.TabIndex = 14;
            this.labelTotalIncome.Text = "000000000 /=";
            // 
            // buttonDownloadReport
            // 
            this.buttonDownloadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadReport.Location = new System.Drawing.Point(52, 126);
            this.buttonDownloadReport.Name = "buttonDownloadReport";
            this.buttonDownloadReport.Size = new System.Drawing.Size(309, 46);
            this.buttonDownloadReport.TabIndex = 8;
            this.buttonDownloadReport.Text = "Download Report (Detailed)";
            this.buttonDownloadReport.UseVisualStyleBackColor = true;
            this.buttonDownloadReport.Click += new System.EventHandler(this.buttonDownloadReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Income";
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(383, 19);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(288, 153);
            this.listViewTransactions.TabIndex = 12;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.SelectedIndexChanged += new System.EventHandler(this.listViewTransactions_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(1, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 55);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxExpense;
        private System.Windows.Forms.CheckBox checkBoxIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.Button buttonDownloadReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.Label labelTotalIncome;
    }
}