using Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Manager.Program;

namespace Manager.Views
{
    public partial class UpdateTransactionView : Form
    {
        private Manager.Transaction transaction;
        private Models.Transaction transactionModel;
        internal event StatusMessageUpdater NotifyParent;
        List<Manager.Contact> contactList;
        Models.Contact contactModel;

        public UpdateTransactionView(Manager.Transaction transaction)
        {
            InitializeComponent();
            transactionModel = new Models.Transaction(new DSFinance(), new FinaceManagerADODBContainer());
            contactList = new List<Manager.Contact>();
            contactModel = new Models.Contact(new FinaceManagerADODBContainer());
            this.transaction = transaction;

            this.FormClosing += UpdateTransactionView_FormClosing;
            loadTransaction();

            
        }

        private void UpdateTransactionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.NotifyParent(Properties.Resources.RELOAD);
        }

        private void loadAllContacts()
        {

        }

        private async void loadTransaction()
        {
            try
            {

                if (transaction.TransactionType == Utillities.TransactionEnum.Income.ToString())
                {
                    this.Text = "Edit Income (ID: " + transaction.Id + ")";
                    this.labelContactType.Text = "Payee";
                    this.labelEditTransactionTitle.Text = "Edit Income";
                    this.buttonUpdateTransaction.Text = "Update Income";
                }
                else if (transaction.TransactionType == Utillities.TransactionEnum.Expense.ToString())
                {
                    this.Text = "Edit Expense (ID: " + transaction.Id + ")";
                    this.labelContactType.Text = "Payer";
                    this.labelEditTransactionTitle.Text = "Edit Expense";
                    this.buttonUpdateTransaction.Text = "Update Expense";
                }

                this.textBoxName.Text = transaction.Name;
                this.textBoxComment.Text = transaction.Comment;
                this.textBoxAmount.Text = transaction.Amount.ToString();
                this.dateTimePickerTransaction.Value = transaction.Date;


                contactList = await GetAllContactsAsync();
                int contactSelected = -1;
                int counter = 0;
                comboBoxContact.Items.Clear();
                foreach (Manager.Contact contactLoop in contactList)
                {
                    comboBoxContact.Items.Add(contactLoop.Name);
                    if(transaction.Contact != null)
                    {
                        if(contactLoop.Id == transaction.Contact.Id)
                        {
                            contactSelected = counter;
                        }
                    }
                    counter++;
                }
                comboBoxContact.SelectedIndex = contactSelected;

                /*if (transaction.Contact != null)
                {
                    if (transaction.Contact.Name != null)
                    {
                        this.comboBoxContact.Text = transaction.Contact.ToString();
                    }
                    else
                    {
                        this.comboBoxContact.SelectedIndex = -1;
                    }

                }
                else
                {
                    this.comboBoxContact.SelectedIndex = -1;
                }*/
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please restart the view ", "Someting went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<Manager.Contact>> GetAllContactsAsync()
        {
            contactList = await Task.Run(() => contactModel.ListContacts());
            return contactList;
        }

        private void UpdateTransactionView_Load(object sender, EventArgs e)
        {

        }

        private async void buttonUpdateTransaction_Click(object sender, EventArgs e)
        {
            double amount = 0.0;

            if (this.textBoxName.Text.TrimStart().TrimEnd().Equals(String.Empty))
            {
                MessageBox.Show("Transcation name cannot be empty", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Double.TryParse(this.textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Invalid data", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                Double.TryParse(this.textBoxAmount.Text, out amount);
                Manager.Transaction updatedTransaction = new Manager.Transaction();
                updatedTransaction.Name = this.textBoxName.Text.TrimStart().TrimEnd();
                updatedTransaction.Id = transaction.Id;
                updatedTransaction.TransactionType = transaction.TransactionType;
                updatedTransaction.Date = this.dateTimePickerTransaction.Value;
                if (comboBoxContact.SelectedIndex == -1)
                {
                    updatedTransaction.Contact = null;
                }
                else
                {
                    updatedTransaction.Contact = contactList[comboBoxContact.SelectedIndex];
                }
                updatedTransaction.Amount = amount;
                updatedTransaction.Comment = this.textBoxComment.Text.TrimStart().TrimEnd();
                await updateTransactionAsync(updatedTransaction);

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task updateTransactionAsync(Manager.Transaction transaction)
        {
            bool result = await Task.Run(() => transactionModel.updateTransaction(transaction));
            if (result)
            {
                MessageBox.Show("Tranasaction updated. ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.transaction = transaction;
                //loadTransaction();

                this.NotifyParent(Properties.Resources.RELOAD);
            }
            else
            {
                MessageBox.Show("Unable to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }
    }
}
