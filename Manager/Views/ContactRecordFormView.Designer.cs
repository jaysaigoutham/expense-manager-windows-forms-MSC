namespace Manager.Views
{
    partial class ContactRecordFormView
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
            this.textBoxContactComments = new System.Windows.Forms.TextBox();
            this.textBoxContactNo = new System.Windows.Forms.TextBox();
            this.textBoxContaactName = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Contact";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 55);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxContactComments);
            this.groupBox1.Controls.Add(this.textBoxContactNo);
            this.groupBox1.Controls.Add(this.textBoxContaactName);
            this.groupBox1.Controls.Add(this.buttonAddContact);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 306);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // textBoxContactComments
            // 
            this.textBoxContactComments.Location = new System.Drawing.Point(164, 163);
            this.textBoxContactComments.Multiline = true;
            this.textBoxContactComments.Name = "textBoxContactComments";
            this.textBoxContactComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContactComments.Size = new System.Drawing.Size(258, 67);
            this.textBoxContactComments.TabIndex = 16;
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Location = new System.Drawing.Point(164, 109);
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(258, 20);
            this.textBoxContactNo.TabIndex = 15;
            this.textBoxContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // textBoxContaactName
            // 
            this.textBoxContaactName.Location = new System.Drawing.Point(164, 55);
            this.textBoxContaactName.Name = "textBoxContaactName";
            this.textBoxContaactName.Size = new System.Drawing.Size(258, 20);
            this.textBoxContaactName.TabIndex = 14;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.BackColor = System.Drawing.Color.Black;
            this.buttonAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddContact.ForeColor = System.Drawing.Color.OldLace;
            this.buttonAddContact.Location = new System.Drawing.Point(228, 254);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(194, 35);
            this.buttonAddContact.TabIndex = 13;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = false;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name *";
            // 
            // ContactRecordFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContactRecordFormView";
            this.Text = "ContactRecordFormView";
            this.Load += new System.EventHandler(this.ContactRecordFormView_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.TextBox textBoxContactComments;
        private System.Windows.Forms.TextBox textBoxContactNo;
        private System.Windows.Forms.TextBox textBoxContaactName;
    }
}