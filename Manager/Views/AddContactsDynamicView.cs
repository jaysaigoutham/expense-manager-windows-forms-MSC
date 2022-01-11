using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.Views
{
    public partial class AddContactsDynamicView : Form
    {

        private Label[] contactNameLabel;
        private TextBox[] contactNameTextbox;
        private Label[] contactPhoneLabel;
        private TextBox[] contactPhoneTextbox;

        private Models.Contact contactModel = new Models.Contact(new FinaceManagerADODBContainer());

        bool alreadyAdded = false;

        public AddContactsDynamicView()
        {
            InitializeComponent();

            this.bulkControlHeader.buttonGenerate.Click += new
            System.EventHandler(this.buttonSubmit_Click);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (bulkControlHeader.NoOfFields < 1 || bulkControlHeader.NoOfFields > 10)
            {
                MessageBox.Show("Please select a range between 1 - 10", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alreadyAdded)
            {
                MessageBox.Show("ALready you have populated entries", "hold on !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            contactNameLabel = new Label[bulkControlHeader.NoOfFields];
            contactNameTextbox = new TextBox[bulkControlHeader.NoOfFields];
            contactPhoneLabel = new Label[bulkControlHeader.NoOfFields];
            contactPhoneTextbox = new TextBox[bulkControlHeader.NoOfFields];
            customSubmitButton.Enabled = true;

            for (int i = 0; i < bulkControlHeader.NoOfFields; i++)
            {

                System.Drawing.Point p1 = new System.Drawing.Point(100, 160 + i * 25);
                contactNameLabel[i] = new Label();
                contactNameLabel[i].Text = "Contact Name* ";
                contactNameLabel[i].Location = p1;
                contactNameLabel[i].Size = new System.Drawing.Size(80, 20);
                this.Controls.Add(contactNameLabel[i]);

                System.Drawing.Point p2 = new System.Drawing.Point(100 + contactNameLabel[i].Size.Width, 160 + i * 25);
                contactNameTextbox[i] = new TextBox();
                contactNameTextbox[i].Location = p2;
                contactNameTextbox[i].Size = new System.Drawing.Size(120, 20);
                this.Controls.Add(contactNameTextbox[i]);

                System.Drawing.Point p3 = new System.Drawing.Point(100 + contactNameLabel[i].Size.Width
                    + contactNameTextbox[i].Size.Width + 50, 160 + i * 25);
                contactPhoneLabel[i] = new Label();
                contactPhoneLabel[i].Text = "Contact Phone Number ";
                contactPhoneLabel[i].Location = p3;
                contactPhoneLabel[i].Size = new System.Drawing.Size(80, 20);
                this.Controls.Add(contactPhoneLabel[i]);

                System.Drawing.Point p4 = new System.Drawing.Point(100 + contactNameLabel[i].Size.Width
                    + contactNameTextbox[i].Size.Width + contactPhoneLabel[i].Size.Width + 50, 160 + i * 25);
                contactPhoneTextbox[i] = new TextBox();
                contactPhoneTextbox[i].Location = p4;
                contactPhoneTextbox[i].Size = new System.Drawing.Size(120, 20);
                contactPhoneTextbox[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
                this.Controls.Add(contactPhoneTextbox[i]);


                //add some mouse events for the text boxes
                //textBoxComputers[i].MouseEnter += new System.EventHandler(this.textBox_mouseEnter);
                //textBoxComputers[i].MouseLeave += new System.EventHandler(this.textBox_mouseLeave);

            }

            alreadyAdded = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bulkControlHeader_Load(object sender, EventArgs e)
        {

        }

        private void customSubmitButton1_Click(object sender, EventArgs e)
        {

        }

        private void removeAllControls()
        {
            int times = bulkControlHeader.NoOfFields;


            for (int i = 0; i < times; i++)
            {
                this.Controls.Remove(contactNameLabel[i]);
                this.Controls.Remove(contactNameTextbox[i]);
                this.Controls.Remove(contactPhoneLabel[i]);
                this.Controls.Remove(contactPhoneTextbox[i]);

              

               
            }

            contactNameLabel = null;
            contactNameTextbox = null;
            contactPhoneLabel = null;
            contactPhoneTextbox = null;

            alreadyAdded = false;
        }

        private async void customSubmitButton_Click(object sender, EventArgs e)
        {
            bool validationPased = true;
            bool insertionToDBAllPassed = true;
            List<Manager.Contact> contactlist = new List<Contact>();

            for (int i = 0; i < bulkControlHeader.NoOfFields; i++)
            {
                int phoneNo = 0;

                if (contactNameTextbox[i].Text.Trim().Length < 1)
                {
                    validationPased = false;
                }
                if(contactPhoneTextbox[i].Text.Length != 0)
                {
                    if (!Int32.TryParse(contactPhoneTextbox[i].Text, out phoneNo))
                    {
                        validationPased = false;
                    }
                }
            }

            if (!validationPased)
            {
                MessageBox.Show("Please make sure that the fields are filled with correct values", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < bulkControlHeader.NoOfFields; i++)
            {
                int phoneNo = 0;
                bool validationPass = true;
                Manager.Contact contact = new Manager.Contact();
                contact.Name = contactNameTextbox[i].Text.TrimStart().TrimEnd();
                Int32.TryParse(contactPhoneTextbox[i].Text, out phoneNo);
                if(phoneNo == 0)
                {
                    contact.PhoneNumber = null;
                }
                else
                {
                    contact.PhoneNumber = phoneNo;
                }
                contact.Date = DateTime.Now.Date;
                
                contact.Comment = String.Empty;

                contactlist.Add(contact);
            }

            if (!await AddContactsAsync(contactlist))
            {
                MessageBox.Show("Error occured while inserting data", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("All records inserted sucessfully", "Perfect !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddContactsDynamicView addContactsDynamicView = new AddContactsDynamicView();
                this.Visible = false;
                this.Close();
                addContactsDynamicView.ShowDialog();
                //addContactsDynamicView.Activate();

                //removeAllControls();
            }


        }

        private async Task<bool> AddContactsAsync(List<Manager.Contact> contacts)
        {
            bool result = await Task.Run(() => contactModel.AddMultipleContacts(contacts));
            return result;
            /*AddMultipleContacts
            bool[] addedtoDB = new bool[bulkControlHeader.NoOfFields];
            int i = 0;
            bool anyOneOperationFailed = false;
            foreach (Manager.Contact contact in contacts)
            {
                bool result = await Task.Run(() => contactModel.AddContact(contact));
                addedtoDB[i] = result;
                if(result )
            }
            return true;*/
        }

        private void AddContactsDynamicView_Load(object sender, EventArgs e)
        {
            customSubmitButton.Enabled = false;
            alreadyAdded = false;
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (alreadyAdded)
                {
                    removeAllControls();
                    alreadyAdded = false;
                }
            }
            catch(Exception ex)
            {
                
            }
            
        }
    }
}
