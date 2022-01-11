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
    public partial class ContactListView : Form
    {
        Models.Contact contactModel;
        List<Manager.Contact> contacts;

        public ContactListView()
        {
            InitializeComponent();
            listViewContacts.MouseDown += ListViewContacts_MouseDown;
            listViewContacts.MouseUp += listViewContacts_MouseUp;

            listViewContacts.AllowColumnReorder = false;
            listViewContacts.AllowDrop = false;
            this.listViewContacts.LostFocus += (s, e) => this.listViewContacts.SelectedIndices.Clear();
        }

        private void listViewContacts_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ListViewContacts_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var info = listViewContacts.HitTest(e.X, e.Y);
                var row = info.Item.Index;
                var col = info.Item.SubItems.IndexOf(info.SubItem);
                var value = info.Item.SubItems[col].Text;
                //MessageBox.Show(string.Format("R{0}:C{1} val '{2}'", row, col, value));
                listViewContacts.SelectedItems.Clear();

                if (col == 4)
                {
                    openUpdate(row);
                }

                return;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Unable to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void openUpdate(int row)
        {
            Manager.Contact selectedContact = contacts.ElementAt(row);

            UpdateContactFormView updateContactFormView = new UpdateContactFormView(selectedContact);
            updateContactFormView.NotifyParent += UpdateContactFormView_NotifyParent; ;
            updateContactFormView.Activate();
            updateContactFormView.ShowDialog();
        }

        private void UpdateContactFormView_NotifyParent(string message)
        {
            if (message.Equals(Properties.Resources.RELOAD))
            {
                clearListview();
                setupListView();
                loadContacts();
            }
        }

        private void ContactListView_Load(object sender, EventArgs e)
        {
            contactModel = new Models.Contact(new FinaceManagerADODBContainer());
            setupListView();
            loadContacts();
        }

        private void setupListView()
        {
            listViewContacts.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewContacts.Columns.Add("ContactNo", 80, HorizontalAlignment.Left);
            listViewContacts.Columns.Add("Added on", 100, HorizontalAlignment.Left);
            listViewContacts.Columns.Add("Comments", 130, HorizontalAlignment.Left);
            listViewContacts.Columns.Add("Update", 75, HorizontalAlignment.Center);
            listViewContacts.MultiSelect = false;
            listViewContacts.FullRowSelect = true;
            listViewContacts.View = View.Details;
            listViewContacts.Activation = ItemActivation.OneClick;
            listViewContacts.LabelEdit = false;
        }

        private void clearListview()
        {
            listViewContacts.Clear();
        }

        private void loadContacts()
        {
            contacts = contactModel.ListContacts();
            foreach (Manager.Contact contact in contacts)
            {
                ListViewItem lvi = new ListViewItem(contact.Name);
                lvi.SubItems.Add(contact.PhoneNumber.ToString());
                lvi.SubItems.Add(contact.Date.ToString("MMMM dd yyyy"));
                lvi.SubItems.Add(contact.Comment);
                lvi.SubItems.Add("update");
                lvi.UseItemStyleForSubItems = false;

                listViewContacts.Items.Add(lvi);
            }
            ChangeToUnderline(ref listViewContacts, 4, Color.Blue);
        }

        private void ChangeToUnderline(ref ListView lv, int ColumnIndex, Color color)
        {

            foreach (ListViewItem lvi in lv.Items)
            {
                lvi.SubItems[ColumnIndex].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Underline);
                lvi.SubItems[ColumnIndex].ForeColor = color;
            }
        }
    }
}
