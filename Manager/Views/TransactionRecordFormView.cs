using Manager.Utillities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.Views
{
    public partial class TransactionRecordFormView : Form
    {
        private Models.Transaction transactionModel;
        private Models.Contact contactModel;
        private List<Manager.Contact> contactList;
        private DSFinance dSFinance = new DSFinance();
        private bool formClosed = false;
        private bool saved = false;

        public TransactionRecordFormView()
        {
            InitializeComponent();
            this.FormClosing += TransactionRecordFormView_FormClosing;
        }

        private async void TransactionRecordFormView_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!formClosed)
            {
                try
                {
                    DSFinance.TransactionRow row = this.dSFinance.Transaction.NewTransactionRow();
                    row.TransactionType = comboBoxTransactionType.SelectedIndex;
                    row.Name = textBoxName.Text.TrimStart().TrimEnd();
                    row.Contact = comboBoxContact.SelectedIndex;
                    row.Date = dateTimePickerTransaction.Value.Date;
                    row.Amount = textBoxAmount.Text;
                    row.Comment = textBoxComment.Text.TrimStart().TrimEnd();
                    this.dSFinance.Transaction.AddTransactionRow(row);
                    this.dSFinance.AcceptChanges();

                    await AddTransactionTeampDataAsync();
                }
                catch (Exception ex)
                {

                }

                this.formClosed = true;
                this.Close();
            }

        }

        private async Task AddTransactionTeampDataAsync()
        {
            try
            {

                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Transaction.xml");
                this.dSFinance.WriteXml(filepath);
            }
            catch(Exception ex)
            {

            }

        }

        private void deleteXMLFile()
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Transaction.xml");
                File.Delete(filepath);
            }
            catch (Exception ex)
            {

            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                //validation
                bool validationSucess = true;
                double amount = 0.0;
                if (textBoxName == null || textBoxName.Text.TrimStart().TrimEnd() == string.Empty)
                {
                    validationSucess = false;
                }

                if (!Double.TryParse(textBoxAmount.Text.Trim(), out amount))
                {
                    validationSucess = false;
                }

                if (!validationSucess)
                {
                    MessageBox.Show("Please input valid data", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //construction
                Manager.Transaction transaction = new Manager.Transaction();
                transaction.Name = textBoxName.Text.TrimStart().TrimEnd();
                transaction.Amount = amount;
                transaction.TransactionType = comboBoxTransactionType.SelectedItem.ToString();
                transaction.Date = dateTimePickerTransaction.Value;
                if (comboBoxContact.SelectedIndex == -1)
                {
                    transaction.Contact = null;
                }
                else
                {
                    transaction.Contact = contactList[comboBoxContact.SelectedIndex];
                }
                transaction.Comment = textBoxComment.Text.TrimStart().TrimEnd();

                if (await AddTransactionRecordAsync(transaction))
                {
                    MessageBox.Show("Sucess");
                    saved = true;

                    //Remove all temp data after loading 
                    dSFinance.Transaction.Rows.Clear();
                    this.dSFinance.AcceptChanges();

                    File.Delete(String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointment.xml"));


                    initialLoad();
                }
                else
                {
                    MessageBox.Show("Failure. Please try again later");
                }
            }
            catch(Exception ex)
            {

            }
            
        }

       

        private async Task<bool> AddTransactionRecordAsync(Manager.Transaction transaction)
        {
            bool result = await Task.Run(() => transactionModel.AddTransaction(transaction));
            return result;
        }

        private  void TransactionRecordFormView_Load(object sender, EventArgs e)
        {
            initialLoad();
            
        }

        private async void initialLoad()
        {
            try
            {
                transactionModel = new Models.Transaction(new DSFinance(), new FinaceManagerADODBContainer());
                contactModel = new Models.Contact(new FinaceManagerADODBContainer());
                contactList = new List<Manager.Contact>();


                comboBoxTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxContact.DropDownStyle = ComboBoxStyle.DropDownList;

                //inital value loading
                comboBoxTransactionType.Items.Clear();
                comboBoxTransactionType.Items.Add(TransactionEnum.Income);
                comboBoxTransactionType.Items.Add(TransactionEnum.Expense);
                textBoxName.Text = null;
                textBoxAmount.Text = null;
                dateTimePickerTransaction.Value = DateTime.Today;
                textBoxComment.Text = null;

                comboBoxTransactionType.SelectedItem = TransactionEnum.Income;
                comboBoxContact.SelectedItem = null;


                contactList = await GetAllContactsAsync();
                comboBoxContact.Items.Clear();
              
                foreach (Manager.Contact contactLoop in contactList)
                {
                    comboBoxContact.Items.Add(contactLoop.Name);
                }

                if(!saved)
                {
                    readFormData();
                }

                
            }
            catch(Exception ex)
            {

            }

        }

        private void readFormData()
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Transaction.xml");
                this.dSFinance.ReadXml(filepath);

                DataRow[] searchResults = this.dSFinance.Transaction.Select();
                this.dSFinance.Transaction.AcceptChanges();

                if (searchResults[searchResults.Length -1] != null)
                {
                    DSFinance.TransactionRow row = (DSFinance.TransactionRow)searchResults[searchResults.Length - 1];
                    comboBoxTransactionType.SelectedIndex = row.TransactionType;
                    textBoxName.Text = row.Name;
                    comboBoxContact.SelectedIndex = row.Contact;
                    dateTimePickerTransaction.Value = row.Date;
                    textBoxAmount.Text = row.Amount.ToString();
                    textBoxComment.Text = row.Comment;


                    searchResults[searchResults.Length - 1].Delete();
                }

                this.dSFinance.Transaction.Clear();
                this.dSFinance.Transaction.AcceptChanges();
                AddTransactionTeampDataAsync();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error occured" + ex.Message);
            }
        }

        private async Task<List<Manager.Contact>> GetAllContactsAsync()
        {
            contactList = await Task.Run(() => contactModel.ListContacts());
            return contactList;
        }

        private void dateTimePickerTransaction_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
