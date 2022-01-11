using Manager.Utillities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace Manager.Views
{
    public partial class EventWeekView : Form
    {

        Models.Event eventModel;
        Models.Transaction transactionModel;
        List<Manager.Event> result;
        List<Manager.Transaction> Transactionresult;
        List<DateTime> resultDates;
        List<Manager.Event> resultByDate;
        List<Manager.Transaction> resultByDateTransaction;

        public EventWeekView()
        {
            InitializeComponent();
        }

        private async void buttonViewReport_Click(object sender, EventArgs e)
        {

            if (dateTimePickerStartDate.Value.Date > dateTimePickerEndDate.Value.Date)
            {
                MessageBox.Show("Start date cannot be greater than end date");
                return;
            }
            result = await GetEventsAsnyc(true, true, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date);
            Transactionresult = await GetTransactionsAsnyc(true, true, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date);
            if (result.Count == 0 && Transactionresult.Count == 0)
            {
                clearlistView();
                MessageBox.Show("No results found !");
            }
            else
            {
                clearlistView();
                loadDates();
                setupListView();
                setupListViewTransaction();
                comboBoxDate.SelectedIndex = 0;
                loadEventsByDate(resultDates[comboBoxDate.SelectedIndex]);
                loadTransactionsByDate(resultDates[comboBoxDate.SelectedIndex]);
            }
        }

        private void loadTransactionsByDate(DateTime selectedDate)
        {
            try
            {
                resultByDateTransaction.Clear();
                foreach (Manager.Transaction transactionOne in Transactionresult)
                {
                    if (selectedDate.Date == transactionOne.Date)
                    {
                        resultByDateTransaction.Add(transactionOne);
                    }
                }
                listViewFinance.Items.Clear();
                LoadTransacionsByDate(resultByDateTransaction);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wring ! please restart applicaiton");
            }
        }

        private void clearlistView()
        {
            listViewEvents.Items.Clear();
            comboBoxDate.Items.Clear();
        }

        private void loadDates()
        {
            for (var dt = dateTimePickerStartDate.Value.Date; dt <= dateTimePickerEndDate.Value.Date; dt = dt.AddDays(1))
            {
                resultDates.Add(dt);
                comboBoxDate.Items.Add(dt.ToString("MMMM dd, yyyy"));
            }

        }

        private void loadEventsByDate(DateTime selectedDate)
        {
            try
            {
                resultByDate.Clear();
                foreach (Manager.Event eventOne in result)
                {
                    if(selectedDate.Date >= eventOne.StartDate && selectedDate.Date <= eventOne.EndDate)
                    {
                        resultByDate.Add(eventOne);
                    }
                }
                LoadEventsByDate(resultByDate);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wring ! please restart applicaiton");
            }
        }

        private void LoadTransacionsByDate(List<Manager.Transaction> transactionsByDate)
        {
            try
            {
                foreach (Manager.Transaction transactionOne in transactionsByDate)
                {
                    ListViewItem lvi = new ListViewItem(transactionOne.Name);
                    lvi.SubItems.Add(transactionOne.TransactionType.ToString());
                    if (transactionOne.Contact != null && transactionOne.Contact.Name != null)
                    {
                        lvi.SubItems.Add(transactionOne.Contact.Name.ToString());
                    }
                    else
                    {
                        lvi.SubItems.Add(string.Empty);
                    }
                    lvi.SubItems.Add("");
                    lvi.UseItemStyleForSubItems = false;

                    listViewFinance.Items.Add(lvi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wring ! please restart applicaiton");
            }
        }

        private void LoadEventsByDate(List<Manager.Event> eventsByDate)
        {
            try
            {
                var imageList = new ImageList();
                imageList.Images.Add("incomeIcon", Properties.Resources.income);
                imageList.Images.Add("expenseIcon", Properties.Resources.expense);
                imageList.Images.Add("appointmentIcon", Properties.Resources.appointment);
                imageList.Images.Add("taskIcon", Properties.Resources.task);

                listViewEvents.Items.Clear();
                foreach (Manager.Event eventOne in eventsByDate)
                {
                    ListViewItem lvi = new ListViewItem(eventOne.Name);
                    lvi.SubItems.Add(eventOne.EventType.ToString());

                    if(eventOne.EventType == EventEnum.Appointment.ToString())
                    {
                        lvi.ImageKey = "appointmentIcon";
                    }
                    else if(eventOne.EventType == EventEnum.Task.ToString())
                    {
                        lvi.ImageKey = "taskIcon";
                    }


                    /*if (eventOne.Contact != null && eventOne.Contact.Name != null)
                    {
                        lvi.SubItems.Add(eventOne.Contact.Name.ToString());
                    }
                    else
                    {
                        lvi.SubItems.Add(string.Empty);
                    }*/
                    lvi.SubItems.Add(eventOne.Comment);
                    lvi.UseItemStyleForSubItems = false;

                    listViewEvents.Items.Add(lvi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wring ! please restart applicaiton");
            }
        }

        private void setupListView()
        {
            listViewEvents.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewEvents.Columns.Add("Type", 80, HorizontalAlignment.Left);
            listViewEvents.Columns.Add("Comment", 180, HorizontalAlignment.Left);
            listViewEvents.MultiSelect = false;
            listViewEvents.FullRowSelect = true;
            listViewEvents.View = View.Details;
            listViewEvents.Activation = ItemActivation.OneClick;
            listViewEvents.LabelEdit = true;
        }

        private void setupListViewTransaction()
        {
            listViewFinance.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewFinance.Columns.Add("Type", 80, HorizontalAlignment.Left);
            listViewFinance.Columns.Add("Payer", 100, HorizontalAlignment.Left);
            listViewFinance.Columns.Add("Amount", 80, HorizontalAlignment.Left);
            listViewFinance.MultiSelect = false;
            listViewFinance.FullRowSelect = true;
            listViewFinance.View = View.Details;
            listViewFinance.Activation = ItemActivation.OneClick;
            listViewFinance.LabelEdit = true;
        }

        private async Task<List<Manager.Event>> GetEventsAsnyc(bool includeTask, bool includeAppointment, DateTime startDate, DateTime endDate)
        {
            List<Manager.Event> result = await Task.Run(() => eventModel.getFilteredEvents(includeTask, includeAppointment, startDate, endDate));
            return result;
        }

        private async Task<List<Manager.Transaction>> GetTransactionsAsnyc(bool includeIncome, bool includeExpense, DateTime startDate, DateTime endDate)
        {
            List<Manager.Transaction> result = await Task.Run(() => transactionModel.getFilteredTransaction(includeIncome, includeExpense, startDate, endDate));
            return result;
        }

        private void EventWeekView_Load(object sender, EventArgs e)
        {
            initialLoad();
        }

        private async void initialLoad()
        {
            try
            {

                eventModel = new Models.Event(new FinaceManagerADODBContainer());
                transactionModel = new Models.Transaction(new DSFinance(), new FinaceManagerADODBContainer());
                result = new List<Manager.Event>();
                resultDates = new List<DateTime>();
                resultByDate = new List<Manager.Event>();
                resultByDateTransaction = new List<Manager.Transaction>();

                dateTimePickerStartDate.Value = DateTime.Today.Date;
                dateTimePickerEndDate.Value = DateTime.Today.Date;

            }
            catch (Exception ex)
            {

            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewEvents.Items.Clear();
            listViewFinance.Items.Clear();

            //setupListView();
            //setupListViewTransaction();

            DateTime selectedDate = resultDates[comboBoxDate.SelectedIndex];
            loadEventsByDate(selectedDate);
            loadTransactionsByDate(selectedDate);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
