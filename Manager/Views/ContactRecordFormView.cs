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
    public partial class ContactRecordFormView : Form
    {
        Models.Contact contactModel;
        private DSFinance dSFinance = new DSFinance();
        private bool formClosed = false;
        private bool saved = false;

        public ContactRecordFormView()
        {
            InitializeComponent();
            this.FormClosing += ContactRecordFormView_FormClosing;
        }

        private async void ContactRecordFormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
            {
                try
                {
                    DSFinance.ContactRow row = this.dSFinance.Contact.NewContactRow();
                    row.Name = textBoxContaactName.Text.TrimStart().TrimEnd();
                    row.ContactNo = textBoxContactNo.Text.TrimStart().TrimEnd();
                    row.Comments = textBoxContactComments.Text.TrimStart().TrimEnd();
                    this.dSFinance.Contact.AddContactRow(row);
                    this.dSFinance.AcceptChanges();

                    await AddCOntactDataAsync();
                }
                catch (Exception ex)
                {

                }

                this.formClosed = true;
                this.Close();
            }
        }

        private async Task AddCOntactDataAsync()
        {

            string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contact.xml");
             this.dSFinance.WriteXml(filepath);
        }

        private async void buttonAddContact_Click(object sender, EventArgs e)
        {

            int phonenum = 0;
            //validation
            if (textBoxContaactName.Text.TrimStart().TrimEnd().Length == 0)
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            if(textBoxContactNo.Text.Length != 0)
            {
                if (!Int32.TryParse(textBoxContactNo.Text.Trim(), out phonenum))
                {
                    MessageBox.Show("Contact no cannot be empty");
                    return;
                }
            }
           

            Int32.TryParse(textBoxContactNo.Text.Trim(), out phonenum);
            Manager.Contact newContact = new Manager.Contact();
            newContact.Name = textBoxContaactName.Text.TrimStart().TrimEnd();
            if (phonenum == 0)
            {
                newContact.PhoneNumber = null;
            }
            else
            {
                newContact.PhoneNumber = phonenum;
            }
            newContact.Date = DateTime.Now.Date;
            newContact.Comment = textBoxContactComments.Text.TrimStart().TrimEnd();

            if(await AddContactAsync(newContact))
            {
                MessageBox.Show("Success");
                saved = true;

                //Remove all temp data after loading 
                dSFinance.Transaction.Rows.Clear();
                this.dSFinance.AcceptChanges();

                File.Delete(String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contact.xml"));



                initLoad();
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }
        private void readFormData()
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contact.xml");
                this.dSFinance.ReadXml(filepath);

                DataRow[] searchResults = this.dSFinance.Contact.Select();
                this.dSFinance.Contact.AcceptChanges();

                if (searchResults[searchResults.Length - 1] != null)
                {
                    DSFinance.ContactRow row = (DSFinance.ContactRow)searchResults[searchResults.Length - 1];
                    textBoxContaactName.Text = row.Name;
                    textBoxContactNo.Text = row.ContactNo;
                    textBoxContactComments.Text = row.Comments;
                }

                //Remove all temp data after loading 
                dSFinance.Contact.Rows.Clear();
                this.dSFinance.AcceptChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error occured" + ex.Message);
            }
        }

        private void ContactRecordFormView_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        private void initLoad()
        {
            contactModel = new Models.Contact(new FinaceManagerADODBContainer());

            textBoxContaactName.Text = String.Empty;
            textBoxContactNo.Text = String.Empty;
            textBoxContactComments.Text = String.Empty;

            if(!saved)
            {
                readFormData();
            }
        }

        private async Task<bool> AddContactAsync(Manager.Contact contact)
        {
            bool result =  await Task.Run(() => contactModel.AddContact(contact));
            return result;

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
