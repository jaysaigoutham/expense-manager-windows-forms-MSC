namespace Manager.Views
{
    partial class TransactionRecordFormView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.comboBoxContact = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income / Expense *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name *";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Location = new System.Drawing.Point(269, 107);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(218, 21);
            this.comboBoxTransactionType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date  *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add Income / Expense";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(269, 164);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(269, 314);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerTransaction.TabIndex = 10;
            this.dateTimePickerTransaction.ValueChanged += new System.EventHandler(this.dateTimePickerTransaction_ValueChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(269, 374);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComment.Size = new System.Drawing.Size(218, 52);
            this.textBoxComment.TabIndex = 11;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.Color.Black;
            this.buttonAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTransaction.ForeColor = System.Drawing.Color.OldLace;
            this.buttonAddTransaction.Location = new System.Drawing.Point(293, 444);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(194, 35);
            this.buttonAddTransaction.TabIndex = 12;
            this.buttonAddTransaction.Text = "Add Transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(269, 257);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(218, 21);
            this.comboBoxContact.TabIndex = 13;
            this.comboBoxContact.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount *";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(269, 210);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(218, 20);
            this.textBoxAmount.TabIndex = 15;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // TransactionRecordFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(541, 518);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxContact);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.dateTimePickerTransaction);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TransactionRecordFormView";
            this.Text = "TransactionRecordFormView";
            this.Load += new System.EventHandler(this.TransactionRecordFormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.ComboBox comboBoxContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}