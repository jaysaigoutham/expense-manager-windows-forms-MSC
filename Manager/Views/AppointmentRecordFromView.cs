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
    public partial class AppointmentRecordFromView : Form
    {

        private Models.Contact contactModel;
        private Models.Event eventModel;
        private List<Manager.Contact> contactList;
        private DSFinance dSFinance = new DSFinance();
        private bool formClosed = false;
        private bool saved = false;

        public AppointmentRecordFromView()
        {
            InitializeComponent();
            this.FormClosing += AppointmentRecordFromView_FormClosing;
        }

        private async void AppointmentRecordFromView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
            {
                try
                {
                    DSFinance.AppointmentRow row = this.dSFinance.Appointment.NewAppointmentRow();
                    row.Name = textBoxName.Text.TrimStart().TrimEnd();
                    row.Contact = comboBoxContact.SelectedIndex;
                    row.Date = dateTimePickerTransaction.Value.Date;
                    row.IsRecurring = checkBoxRecurring.Checked;
                    row.days = textBoxValidDays.Text;
                    row.Comment = textBoxComment.Text.TrimStart().TrimEnd();
                    this.dSFinance.Appointment.AddAppointmentRow(row);
                    this.dSFinance.AcceptChanges();

                    await AddAppointmentTeampDataAsync(row);
                }
                catch (Exception ex)
                {

                }

                this.formClosed = true;
                this.Close();
            }
        }


        private void readFormData()
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointment.xml");
                this.dSFinance.ReadXml(filepath);

                DataRow[] searchResults = this.dSFinance.Appointment.Select();
                this.dSFinance.Appointment.AcceptChanges();

                if (searchResults[searchResults.Length -1] != null)
                {
                    DSFinance.AppointmentRow row = (DSFinance.AppointmentRow)searchResults[searchResults.Length - 1];
                    textBoxName.Text = row.Name;
                    comboBoxContact.SelectedIndex = row.Contact;
                    dateTimePickerTransaction.Value = row.Date;
                    textBoxComment.Text = row.Comment;
                    checkBoxRecurring.Checked = row.IsRecurring;
                    textBoxValidDays.Text = row.days;
                }

                //Remove all temp data after loading 
                dSFinance.Transaction.Rows.Clear();
                this.dSFinance.AcceptChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error occured" + ex.Message);
            }
        }

        private async Task AddAppointmentTeampDataAsync(DSFinance.AppointmentRow row)
        {

            string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointment.xml");
            this.dSFinance.WriteXml(filepath);
        }

        private void AppointmentRecordFromView_Load(object sender, EventArgs e)
        {
            initialLoad();
        }

        private async void initialLoad()
        {
            try
            {
                contactModel = new Models.Contact(new FinaceManagerADODBContainer());
                eventModel = new Models.Event(new FinaceManagerADODBContainer());
                contactList = new List<Manager.Contact>();

                //load contacts
                contactList = await GetAllContactsAsync();

                comboBoxContact.DropDownStyle = ComboBoxStyle.DropDownList;

                comboBoxContact.Items.Clear();
                foreach (Manager.Contact contactLoop in contactList)
                {
                    comboBoxContact.Items.Add(contactLoop.Name);
                }


                textBoxName.Text = String.Empty;
                dateTimePickerTransaction.Value = DateTime.Today.Date;
                checkBoxRecurring.Checked = false;
                textBoxValidDays.Text = String.Empty;
                textBoxComment.Text = String.Empty;

                if(!saved)
                {
                    readFormData();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private async Task<List<Manager.Contact>> GetAllContactsAsync()
        {
            contactList = await Task.Run(() => contactModel.ListContacts());
            return contactList;
        }

        private void textBoxdays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private async void buttonUpdateTransaction_Click(object sender, EventArgs e)
        {
            int days = 0;
            if(textBoxName.Text.TrimStart().TrimEnd().Length == 0)
            {
                MessageBox.Show("Please input valid name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(checkBoxRecurring.Checked)
            {
               if(!Int32.TryParse(textBoxValidDays.Text.Trim(), out days))
               {
                    MessageBox.Show("Please input valid recutring Dats (1 - 30)", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }
               else
               {
                    if(days < 1 || days > 31)
                    {
                        MessageBox.Show("Please input valid recutring Dats (1 - 30)", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
               }

               
            }

            Manager.Event appointment = new Manager.Event();
            appointment.Name = textBoxName.Text.TrimStart().TrimEnd();
            appointment.StartDate = dateTimePickerTransaction.Value.Date;
            appointment.EventType = EventEnum.Appointment.ToString();
            if (checkBoxRecurring.Checked)
            {
                appointment.RecurringDays = Convert.ToInt16(days);
                appointment.IsRecurring = true;
                appointment.EndDate = dateTimePickerTransaction.Value.Date.AddDays(days);
            }
            else
            {
                appointment.RecurringDays = null;
                appointment.IsRecurring = false;
                appointment.EndDate = null;
            }

            if (comboBoxContact.SelectedIndex == -1)
            {
                appointment.Contact = null;
            }
            else
            {
                appointment.Contact = contactList[comboBoxContact.SelectedIndex];
            }
            appointment.Comment = textBoxComment.Text.TrimStart().TrimEnd();

            if (await AddAppointmentAsnyc(appointment))
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

        private async Task<bool> AddAppointmentAsnyc(Manager.Event appointment)
        {
            bool result = await Task.Run(() => eventModel.AddAppointment(appointment));
            return result;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
