namespace Manager.Views
{
    partial class TransactionListView
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
            this.label2 = new System.Windows.Forms.Label();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(154, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "List of Incomes & Expenses";
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(52, 64);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(455, 319);
            this.listViewTransactions.TabIndex = 11;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TransactionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 420);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.label2);
            this.Name = "TransactionListView";
            this.Text = "TransactionListView";
            this.Load += new System.EventHandler(this.TransactionListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewTransactions;
    }
}