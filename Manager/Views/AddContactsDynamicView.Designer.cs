namespace Manager.Views
{
    partial class AddContactsDynamicView
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
            this.bulkControlHeader = new Manager.CustomUI.BulkContactAddControl();
            this.customSubmitButton = new Manager.CustomUI.CustomSubmitButton();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bluk contact insert";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 55);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bulkControlHeader
            // 
            this.bulkControlHeader.BackColor = System.Drawing.Color.Transparent;
            this.bulkControlHeader.Location = new System.Drawing.Point(69, 86);
            this.bulkControlHeader.Name = "bulkControlHeader";
            this.bulkControlHeader.Size = new System.Drawing.Size(647, 66);
            this.bulkControlHeader.TabIndex = 10;
            this.bulkControlHeader.Load += new System.EventHandler(this.bulkControlHeader_Load);
            // 
            // customSubmitButton
            // 
            this.customSubmitButton.BackColor = System.Drawing.Color.LightGray;
            this.customSubmitButton.Location = new System.Drawing.Point(588, 431);
            this.customSubmitButton.Name = "customSubmitButton";
            this.customSubmitButton.Size = new System.Drawing.Size(200, 60);
            this.customSubmitButton.TabIndex = 0;
            this.customSubmitButton.Text = "Submit";
            this.customSubmitButton.UseVisualStyleBackColor = false;
            this.customSubmitButton.Click += new System.EventHandler(this.customSubmitButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(391, 431);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(191, 60);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // AddContactsDynamicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.customSubmitButton);
            this.Controls.Add(this.bulkControlHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddContactsDynamicView";
            this.Text = "AddContactsDynamicView";
            this.Load += new System.EventHandler(this.AddContactsDynamicView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomUI.BulkContactAddControl bulkControlHeader;
        private CustomUI.CustomSubmitButton customSubmitButton;
        private System.Windows.Forms.Button buttonReset;
    }
}