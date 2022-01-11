namespace Manager.Views
{
    partial class HomeView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFinanceStatus = new System.Windows.Forms.Button();
            this.buttonFinanceReport = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWeeklyView = new System.Windows.Forms.Button();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.buttonCreateAppointment = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBulkAdd = new System.Windows.Forms.Button();
            this.buttonListUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonFinanceStatus);
            this.groupBox1.Controls.Add(this.buttonFinanceReport);
            this.groupBox1.Controls.Add(this.buttonTransactions);
            this.groupBox1.Controls.Add(this.buttonAddTransaction);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(+) Income  (-) Expense management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonFinanceStatus
            // 
            this.buttonFinanceStatus.BackColor = System.Drawing.Color.Black;
            this.buttonFinanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinanceStatus.ForeColor = System.Drawing.Color.OldLace;
            this.buttonFinanceStatus.Location = new System.Drawing.Point(19, 207);
            this.buttonFinanceStatus.Name = "buttonFinanceStatus";
            this.buttonFinanceStatus.Size = new System.Drawing.Size(183, 35);
            this.buttonFinanceStatus.TabIndex = 6;
            this.buttonFinanceStatus.Text = "My Financial Status";
            this.buttonFinanceStatus.UseVisualStyleBackColor = false;
            this.buttonFinanceStatus.Click += new System.EventHandler(this.buttonFinanceStatus_Click);
            // 
            // buttonFinanceReport
            // 
            this.buttonFinanceReport.BackColor = System.Drawing.Color.Black;
            this.buttonFinanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinanceReport.ForeColor = System.Drawing.Color.OldLace;
            this.buttonFinanceReport.Location = new System.Drawing.Point(19, 157);
            this.buttonFinanceReport.Name = "buttonFinanceReport";
            this.buttonFinanceReport.Size = new System.Drawing.Size(183, 35);
            this.buttonFinanceReport.TabIndex = 5;
            this.buttonFinanceReport.Text = "Finance Report";
            this.buttonFinanceReport.UseVisualStyleBackColor = false;
            this.buttonFinanceReport.Click += new System.EventHandler(this.buttonFinanceReport_Click);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.BackColor = System.Drawing.Color.Black;
            this.buttonTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactions.ForeColor = System.Drawing.Color.OldLace;
            this.buttonTransactions.Location = new System.Drawing.Point(19, 106);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(183, 35);
            this.buttonTransactions.TabIndex = 4;
            this.buttonTransactions.Text = "My Income & Expenses";
            this.buttonTransactions.UseVisualStyleBackColor = false;
            this.buttonTransactions.Click += new System.EventHandler(this.buttonTransactions_Click);
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.Color.Black;
            this.buttonAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransaction.ForeColor = System.Drawing.Color.OldLace;
            this.buttonAddTransaction.Location = new System.Drawing.Point(19, 56);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(183, 35);
            this.buttonAddTransaction.TabIndex = 3;
            this.buttonAddTransaction.Text = "Add Income / Expense";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonWeeklyView);
            this.groupBox2.Controls.Add(this.buttonCreateTask);
            this.groupBox2.Controls.Add(this.buttonCreateAppointment);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(294, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 279);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event";
            // 
            // buttonWeeklyView
            // 
            this.buttonWeeklyView.BackColor = System.Drawing.Color.Black;
            this.buttonWeeklyView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeeklyView.ForeColor = System.Drawing.Color.White;
            this.buttonWeeklyView.Location = new System.Drawing.Point(17, 157);
            this.buttonWeeklyView.Name = "buttonWeeklyView";
            this.buttonWeeklyView.Size = new System.Drawing.Size(183, 35);
            this.buttonWeeklyView.TabIndex = 2;
            this.buttonWeeklyView.Text = "Weekly View";
            this.buttonWeeklyView.UseVisualStyleBackColor = false;
            this.buttonWeeklyView.Click += new System.EventHandler(this.buttonWeeklyView_Click);
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.BackColor = System.Drawing.Color.Black;
            this.buttonCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTask.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTask.Location = new System.Drawing.Point(17, 106);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(183, 35);
            this.buttonCreateTask.TabIndex = 1;
            this.buttonCreateTask.Text = "Create Task";
            this.buttonCreateTask.UseVisualStyleBackColor = false;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // buttonCreateAppointment
            // 
            this.buttonCreateAppointment.BackColor = System.Drawing.Color.Black;
            this.buttonCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAppointment.ForeColor = System.Drawing.Color.OldLace;
            this.buttonCreateAppointment.Location = new System.Drawing.Point(17, 56);
            this.buttonCreateAppointment.Name = "buttonCreateAppointment";
            this.buttonCreateAppointment.Size = new System.Drawing.Size(183, 35);
            this.buttonCreateAppointment.TabIndex = 0;
            this.buttonCreateAppointment.Text = "Create Appointment";
            this.buttonCreateAppointment.UseVisualStyleBackColor = false;
            this.buttonCreateAppointment.Click += new System.EventHandler(this.buttonCreateAppointment_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonBulkAdd);
            this.groupBox3.Controls.Add(this.buttonListUser);
            this.groupBox3.Controls.Add(this.buttonAddUser);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(557, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 279);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact";
            // 
            // buttonBulkAdd
            // 
            this.buttonBulkAdd.BackColor = System.Drawing.Color.Black;
            this.buttonBulkAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBulkAdd.ForeColor = System.Drawing.Color.OldLace;
            this.buttonBulkAdd.Location = new System.Drawing.Point(18, 157);
            this.buttonBulkAdd.Name = "buttonBulkAdd";
            this.buttonBulkAdd.Size = new System.Drawing.Size(183, 35);
            this.buttonBulkAdd.TabIndex = 5;
            this.buttonBulkAdd.Text = "Bulk Add";
            this.buttonBulkAdd.UseVisualStyleBackColor = false;
            this.buttonBulkAdd.Click += new System.EventHandler(this.buttonBulkAdd_Click);
            // 
            // buttonListUser
            // 
            this.buttonListUser.BackColor = System.Drawing.Color.Black;
            this.buttonListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListUser.ForeColor = System.Drawing.Color.OldLace;
            this.buttonListUser.Location = new System.Drawing.Point(18, 106);
            this.buttonListUser.Name = "buttonListUser";
            this.buttonListUser.Size = new System.Drawing.Size(183, 35);
            this.buttonListUser.TabIndex = 4;
            this.buttonListUser.Text = "List User";
            this.buttonListUser.UseVisualStyleBackColor = false;
            this.buttonListUser.Click += new System.EventHandler(this.buttonListUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.Black;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.ForeColor = System.Drawing.Color.OldLace;
            this.buttonAddUser.Location = new System.Drawing.Point(18, 56);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(183, 35);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Finance Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(324, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Event Manager";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(574, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Manager";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Image = global::Manager.Properties.Resources.appointment;
            this.pictureBox3.Location = new System.Drawing.Point(622, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Manager.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(369, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Manager.Properties.Resources._1;
            this.pictureBox1.InitialImage = global::Manager.Properties.Resources.income;
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeView";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonCreateAppointment;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button buttonWeeklyView;
        private System.Windows.Forms.Button buttonFinanceStatus;
        private System.Windows.Forms.Button buttonFinanceReport;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Button buttonListUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonBulkAdd;
    }
}