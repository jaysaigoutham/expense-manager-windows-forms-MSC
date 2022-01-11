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
    public partial class TaskRecordFormView : Form
    {

        Models.Event eventModel;
        private bool formClosed = false;
        private DSFinance dSFinance = new DSFinance();
        private bool saved = false;

        public TaskRecordFormView()
        {
            InitializeComponent();
            this.FormClosing += TaskRecordFormView_FormClosing;
        }

        private async void TaskRecordFormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
            {
                try
                {
                    DSFinance.TaskRow row = this.dSFinance.Task.NewTaskRow();
                    row.Name = textBoxName.Text.TrimStart().TrimEnd();
                    row.Date = dateTimePickerTransaction.Value.Date;
                    row.IsRecurring = checkBoxRecurring.Checked;
                    row.days = textBoxValidDays.Text;
                    row.Comment = textBoxComment.Text.TrimStart().TrimEnd();
                    this.dSFinance.Task.AddTaskRow(row);
                    this.dSFinance.AcceptChanges();

                    await AddTaskTeampDataAsync();
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
                string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Task.xml");
                this.dSFinance.ReadXml(filepath);

                DataRow[] searchResults = this.dSFinance.Task.Select();
                this.dSFinance.Task.AcceptChanges();

                if (searchResults[searchResults.Length - 1] != null)
                {
                    DSFinance.TaskRow row = (DSFinance.TaskRow)searchResults[searchResults.Length - 1];
                    textBoxName.Text = row.Name;
                    dateTimePickerTransaction.Value = row.Date;
                    textBoxComment.Text = row.Comment;
                    checkBoxRecurring.Checked = row.IsRecurring;
                    textBoxValidDays.Text = row.days;
                }

                //Remove all temp data after loading 
                dSFinance.Task.Rows.Clear();
                this.dSFinance.AcceptChanges();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error occured" + ex.Message);
            }
        }

        private async Task AddTaskTeampDataAsync()
        {

            string filepath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Task.xml");
            this.dSFinance.WriteXml(filepath);
        }

        private void TaskRecordFormView_Load(object sender, EventArgs e)
        {
            initialLoad();
        }

        private void textBoxdays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }



        private async void initialLoad()
        {
            try
            {
                eventModel = new Models.Event(new FinaceManagerADODBContainer());

                textBoxName.Text = String.Empty;
                dateTimePickerTransaction.Value = DateTime.Today.Date;
                checkBoxRecurring.Checked = false;
                textBoxValidDays.Text = String.Empty;
                textBoxComment.Text = String.Empty;

                if (!saved)
                {
                    readFormData();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private async void buttonAddTask_Click(object sender, EventArgs e)
        {
            int days = 0;
            if (textBoxName.Text.TrimStart().TrimEnd().Length == 0)
            {
                MessageBox.Show("Please input valid name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBoxRecurring.Checked)
            {
                if (!Int32.TryParse(textBoxValidDays.Text.Trim(), out days))
                {
                    MessageBox.Show("Please input valid recutring Dats (1 - 30)", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (days < 1 || days > 31)
                    {
                        MessageBox.Show("Please input valid recutring Dats (1 - 30)", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


            }

            Manager.Event task = new Manager.Event();
            task.Name = textBoxName.Text.TrimStart().TrimEnd();
            task.StartDate = dateTimePickerTransaction.Value.Date;
            task.EventType = EventEnum.Task.ToString();
            if (checkBoxRecurring.Checked)
            {
                task.RecurringDays = Convert.ToInt16(days);
                task.IsRecurring = true;
                task.EndDate = dateTimePickerTransaction.Value.Date.AddDays(days);
            }
            else
            {
                task.RecurringDays = null;
                task.IsRecurring = false;
                task.EndDate = null;
            }

            task.Comment = textBoxComment.Text.TrimStart().TrimEnd();

            if (await AddTaskAsnyc(task))
            {
                MessageBox.Show("Sucess");
                saved = true;

                //Remove all temp data after loading 
                dSFinance.Transaction.Rows.Clear();
                this.dSFinance.AcceptChanges();

                File.Delete(String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Task.xml"));


                initialLoad();
            }
            else
            {
                MessageBox.Show("Failure. Please try again later");
            }
        }

        private async Task<bool> AddTaskAsnyc(Manager.Event task)
        {
            bool result = await Task.Run(() => eventModel.AddAppointment(task));
            return result;
        }
    }
}
