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
    public partial class UpdateContactFormView : Form
    {
        private Manager.Contact contact;
        private Models.Contact contactModel;
        internal event StatusMessageUpdater NotifyParent;

        public UpdateContactFormView(Manager.Contact contact)
        {
            InitializeComponent();

            contactModel = new Models.Contact(new FinaceManagerADODBContainer());


            this.contact = contact;
            this.Text = "Edit Contact (ID: " + contact.Id + ")";
            this.FormClosing += UpdateContactFormView_FormClosing; ;
            loadContact();
        }

        private void loadContact()
        {
            try
            {
                this.textBoxName.Text = contact.Name;
                this.textBoxContactNo.Text = contact.PhoneNumber.ToString();
                this.textBoxComments.Text = contact.Comment;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please restart the view ", "Someting went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateContactFormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.NotifyParent(Properties.Resources.RELOAD);
        }

        private void UpdateContactFormView_Load(object sender, EventArgs e)
        {

        }

        private async Task<bool> updateContactAsync(Manager.Contact contact)
        {
            bool result = await Task.Run(() => contactModel.UpdateContact(contact));
            return result;
        }

        private async void buttonUpdateContact_Click(object sender, EventArgs e)
        {
            int phonenum = 0;
            if (textBoxName.Text.TrimStart().TrimEnd().Length == 0)
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            if(textBoxContactNo.Text.Trim().Length != 0)
            {
                if (!Int32.TryParse(textBoxContactNo.Text.Trim(), out phonenum))
                {
                    MessageBox.Show("Contact no cannot be empty");
                    return;
                }
            }
   
            Int32.TryParse(textBoxContactNo.Text.Trim(), out phonenum);
            Manager.Contact updateContact = new Manager.Contact();
            updateContact.Id = contact.Id;
            updateContact.Name = textBoxName.Text.TrimStart().TrimEnd();
            if(textBoxContactNo.Text.Trim().Length != 0)
            {
                updateContact.PhoneNumber = phonenum;
            }
            else
            {
                updateContact.PhoneNumber = null;
            }
            
            updateContact.Date = contact.Date;
            updateContact.Comment = textBoxComments.Text.TrimStart().TrimEnd();

            if (await updateContactAsync(updateContact))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }
    }
}
