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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            //Background image
            //this.BackgroundImage = Properties.Resources.managerbg;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            TransactionRecordFormView transactionRecordFormView = new TransactionRecordFormView();
            transactionRecordFormView.Activate();
            transactionRecordFormView.Focus();
            transactionRecordFormView.ShowDialog();
        }

        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            TransactionListView transactionListView = new TransactionListView();
            transactionListView.Activate();
            transactionListView.Focus();
            transactionListView.ShowDialog();
        }

        private void buttonFinanceReport_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.Activate();
            reportView.Focus();
            reportView.ShowDialog();
        }

        private void buttonFinanceStatus_Click(object sender, EventArgs e)
        {
            FinanceStatusViewForm financeStatusViewForm = new FinanceStatusViewForm();
            financeStatusViewForm.Activate();
            financeStatusViewForm.Focus();
            financeStatusViewForm.ShowDialog();

        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            TaskRecordFormView taskRecordFormView = new TaskRecordFormView();
            taskRecordFormView.Activate();
            taskRecordFormView.Focus();
            taskRecordFormView.ShowDialog();
        }

        private void buttonCreateAppointment_Click(object sender, EventArgs e)
        {
            AppointmentRecordFromView appointmentRecordFromView = new AppointmentRecordFromView();
            appointmentRecordFromView.Activate();
            appointmentRecordFromView.Focus();
            appointmentRecordFromView.ShowDialog();
        }

        private void buttonWeeklyView_Click(object sender, EventArgs e)
        {
            EventWeekView eventWeekView = new EventWeekView();
            eventWeekView.Activate();
            eventWeekView.Focus();
            eventWeekView.ShowDialog();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            ContactRecordFormView contactRecordFormView = new ContactRecordFormView();
            contactRecordFormView.Activate();
            contactRecordFormView.Focus();
            contactRecordFormView.ShowDialog();
        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            ContactListView contactListView = new ContactListView();
            contactListView.Activate();
            contactListView.Focus();
            contactListView.ShowDialog();
        }

        private void buttonBulkAdd_Click(object sender, EventArgs e)
        {
            AddContactsDynamicView addContactsDynamicView = new AddContactsDynamicView();
            addContactsDynamicView.Activate();
            addContactsDynamicView.Focus();
            addContactsDynamicView.ShowDialog();

        }
    }
}
