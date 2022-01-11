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

namespace Manager.Views
{
    public partial class FinanceStatusViewForm : Form
    {
        private DateTime selectedDate;
        private Models.Transaction transactionModel;
        private Models.Finance financeModel;

        public FinanceStatusViewForm()
        {
            InitializeComponent();
        }

        private void FinanceStatusViewForm_Load(object sender, EventArgs e)
        {
            monthCalendar.DateSelected += MonthCalendar_DateSelected;
            transactionModel = new Models.Transaction(new DSFinance(), new FinaceManagerADODBContainer());
            financeModel = new Models.Finance();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = monthCalendar.SelectionStart;
            monthCalendar.SelectionEnd = selectedDate;
            calcualteFinancialStatus(selectedDate);
        }

        private void calcualteFinancialStatus(DateTime dateTime)
        {
            //futuee date
            /*if(selectedDate > DateTime.Today)
             {
                 labelFinancialStatus.Text = "Not applicabale for future date";

             }*/

            labelSelectedDate.Text = dateTime.ToString("dddd, dd MMMM yyyy");

            double amoutOfLast4DaysIncome = 0.0;
            double amoutOfLast4DaysExpense = 0.0;

            double amoutOfSelectedDayIncome = 0.0;
            double amoutOfSelectedDayExpense = 0.0;

            double balance = 0.0;

            List<Manager.Transaction> incomesOnSelecedDay = financeModel.getFilteredIncomeTransaction(dateTime.Date);
            List<Manager.Transaction> expensesOnSelecedDay = financeModel.getFilteredExpenseTransaction(dateTime.Date);

            List<Manager.Transaction> incomesOfLast4Days = transactionModel.getFilteredTransaction(true, false, dateTime.AddDays(-4).Date, dateTime.AddDays(-1).Date);
            List<Manager.Transaction> expensesOfLast4Days = transactionModel.getFilteredTransaction(false, true, dateTime.AddDays(-4).Date, dateTime.AddDays(-1).Date);
            if (incomesOfLast4Days.Count != 0 || expensesOfLast4Days.Count != 0)
            {
                amoutOfLast4DaysIncome = calculateAmountOnList(incomesOfLast4Days);
                amoutOfLast4DaysExpense = calculateAmountOnList(expensesOfLast4Days);

                balance = amoutOfLast4DaysIncome - amoutOfLast4DaysExpense;
                showResult(balance);
            }
            else if (incomesOnSelecedDay.Count != 0 || expensesOnSelecedDay.Count != 0)
            {
                amoutOfSelectedDayIncome = calculateAmountOnList(incomesOnSelecedDay);
                amoutOfSelectedDayExpense = calculateAmountOnList(expensesOnSelecedDay);
                balance = amoutOfSelectedDayIncome - amoutOfSelectedDayExpense;
                showResult(balance);

            }
            else
            {
                labelFinancialStatus.Text = "Sorry - not suffiencet data available";
                labelFinancialStatus.ForeColor = Color.Gray;
            }

        }

        private void showResult(double balance)
        {
            if(balance >= 0.0)
            {
                labelFinancialStatus.Text = "Be happy - You are in good coddition";
                labelFinancialStatus.ForeColor = Color.Green;
            }
            else
            {
                labelFinancialStatus.Text = "Oops - you are not in good condtion";
                labelFinancialStatus.ForeColor = Color.Red;
            }
        }

        private double calculateAmountOnList(List<Manager.Transaction> transactions)
        {

            double amount = 0.0;
            foreach (Manager.Transaction trans in transactions)
            {
                amount += trans.Amount;
            }
            return amount;
        }
    }
}
