namespace Manager.Views
{
    partial class AppointmentRecordFromView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxRecurring = new System.Windows.Forms.CheckBox();
            this.textBoxValidDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdateTransaction = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxContact = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Create Appointment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 55);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxRecurring);
            this.groupBox1.Controls.Add(this.textBoxValidDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUpdateTransaction);
            this.groupBox1.Controls.Add(this.textBoxComment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxContact);
            this.groupBox1.Controls.Add(this.dateTimePickerTransaction);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 368);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "(Max 30 days)";
            // 
            // checkBoxRecurring
            // 
            this.checkBoxRecurring.AutoSize = true;
            this.checkBoxRecurring.Location = new System.Drawing.Point(252, 185);
            this.checkBoxRecurring.Name = "checkBoxRecurring";
            this.checkBoxRecurring.Size = new System.Drawing.Size(72, 17);
            this.checkBoxRecurring.TabIndex = 24;
            this.checkBoxRecurring.Text = "Recurring";
            this.checkBoxRecurring.UseVisualStyleBackColor = true;
            // 
            // textBoxValidDays
            // 
            this.textBoxValidDays.Location = new System.Drawing.Point(343, 184);
            this.textBoxValidDays.Name = "textBoxValidDays";
            this.textBoxValidDays.Size = new System.Drawing.Size(127, 20);
            this.textBoxValidDays.TabIndex = 23;
            this.textBoxValidDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdays_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Recurring & Validity";
            // 
            // buttonUpdateTransaction
            // 
            this.buttonUpdateTransaction.BackColor = System.Drawing.Color.Black;
            this.buttonUpdateTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTransaction.ForeColor = System.Drawing.Color.OldLace;
            this.buttonUpdateTransaction.Location = new System.Drawing.Point(276, 308);
            this.buttonUpdateTransaction.Name = "buttonUpdateTransaction";
            this.buttonUpdateTransaction.Size = new System.Drawing.Size(194, 35);
            this.buttonUpdateTransaction.TabIndex = 20;
            this.buttonUpdateTransaction.Text = "Add Appointment";
            this.buttonUpdateTransaction.UseVisualStyleBackColor = false;
            this.buttonUpdateTransaction.Click += new System.EventHandler(this.buttonUpdateTransaction_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(252, 239);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComment.Size = new System.Drawing.Size(218, 52);
            this.textBoxComment.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Comment";
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(252, 137);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(218, 21);
            this.comboBoxContact.TabIndex = 17;
            this.comboBoxContact.TabStop = false;
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(252, 89);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerTransaction.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date  *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(252, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name *";
            // 
            // AppointmentRecordFromView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AppointmentRecordFromView";
            this.Text = "AppointmentRecordFromView";
            this.Load += new System.EventHandler(this.AppointmentRecordFromView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxContact;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdateTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValidDays;
        private System.Windows.Forms.CheckBox checkBoxRecurring;
        private System.Windows.Forms.Label label7;
    }
}