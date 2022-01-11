using Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager.Utillities;

namespace Manager.Views
{
    public partial class ReportView : Form
    {

        private Models.Report reportModel;
        List<Manager.Transaction> loadedTransactions;

        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            loadInitialView();
        }

        private void loadInitialView()
        {
            reportModel = new Models.Report(new DSFinance(), new FinaceManagerADODBContainer());
            checkBoxIncome.Checked = true;
            checkBoxExpense.Checked = true;
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            buttonDownloadReport.Enabled = false;
        }

        private async void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            if(dateTimePickerStartDate.Value.Date > dateTimePickerEndDate.Value.Date)
            {
                MessageBox.Show("Start date cannot be greater than end date");
                return;
            }
            List<Manager.Transaction> results =  await GenerateReport(checkBoxIncome.Checked, checkBoxExpense.Checked, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date);
            if (results.Count != 0)
            {
                loadedTransactions = results;
                listViewTransactions.Clear();
                setupListView();
                loadTranscations(results);
                setFilteredResult(results);
                buttonDownloadReport.Enabled = true;
            }
            else
            {
                loadedTransactions = null;
                buttonDownloadReport.Enabled = false;
                listViewTransactions.Clear();
                MessageBox.Show("No results found !");
            }
        }

     
        private async Task<List<Manager.Transaction>> GenerateReport(bool incomeSelectted, bool expenseSelected, DateTime startDate, DateTime endDate)
        {
            List<Manager.Transaction> results = await Task.Run(() => reportModel.getReport(incomeSelectted, expenseSelected, startDate, endDate));
            return results;
        }

        delegate void StatemethoodDelegate(string message);

        private void setFilteredResult(List<Transaction> results)
        {

            double totalIncome = 0.0;
            double totalExpense = 0.0;
            foreach (Transaction transaction in results)
            {
                if(transaction.TransactionType == TransactionEnum.Income.ToString())
                {
                    totalIncome += transaction.Amount;
                }
                else if (transaction.TransactionType == TransactionEnum.Expense.ToString())
                {
                    totalExpense += transaction.Amount;
                }
            }

            labelTotalIncome.Text = totalIncome + "/=";
            labelTotalExpense.Text = totalExpense + "/=";

        }

        private void setupListView()
        {
            listViewTransactions.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Payer", 100, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Date",100, HorizontalAlignment.Left);
            listViewTransactions.MultiSelect = false;
            listViewTransactions.FullRowSelect = true;
            listViewTransactions.View = View.Details;
            listViewTransactions.Activation = ItemActivation.OneClick;
            listViewTransactions.LabelEdit = true;
        }

        private void loadTranscations(List<Manager.Transaction> transactions)
        {

            foreach (Manager.Transaction transaction in transactions)
            {
                ListViewItem lvi = new ListViewItem(transaction.Name);
                if (transaction.Contact != null && transaction.Contact.Name != null)
                {
                    lvi.SubItems.Add(transaction.Contact.Name.ToString());
                }
                else
                {
                    lvi.SubItems.Add(string.Empty);
                }
                lvi.SubItems.Add(transaction.Date.ToString("MMMM dd yyyy"));
                lvi.UseItemStyleForSubItems = false;

                listViewTransactions.Items.Add(lvi);
            }

        }

        private void listViewTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void buttonDownloadReport_Click(object sender, EventArgs e)
        {
           if(loadedTransactions.Count != 0)
           {
                bool result = await Task.Run(() => gernerateReportAsync(loadedTransactions));
                if(result)
                {
                    MessageBox.Show("Report geenerated & saved in desktop for you");
                }
                else
                {
                    MessageBox.Show("failure");
                }
                
            }
        }

        private async Task<bool> gernerateReportAsync(List<Manager.Transaction> transactions)
        {
            try
            {
                string filepath = String.Format("{0}\\{1}{2}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), DateTime.Now.ToString("MMMM dd yyyy"), " report.pdf");
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filepath, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(3);

                // t.setBorderColor(BaseColor.GRAY);
                // t.setPadding(4);
                // t.setSpacing(4);
                // t.setBorderWidth(1);

                document.AddTitle("List of income & expenses");

                Paragraph p = new Paragraph("Please find below ");
                document.Add(p);

                PdfPCell c1 = new PdfPCell(new Phrase("ID & Transaction Name"));
                table.AddCell(c1);

                c1 = new PdfPCell(new Phrase("Type"));
                table.AddCell(c1);

                c1 = new PdfPCell(new Phrase("Amount"));
                table.AddCell(c1);

                table.HeaderRows = 1;

                foreach(Manager.Transaction transaction in transactions)
                {
                    table.AddCell("(" + transaction.Id.ToString() + ") " + transaction.Name);
                    table.AddCell(transaction.TransactionType.ToString());
                    table.AddCell(transaction.Amount.ToString() + "/=");
                }

                

                document.Add(table);


               

                

                document.Close();
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        
        }

        private void checkBoxIncome_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIncome.Checked == false)
            {
                checkBoxExpense.Checked = true;
            }
        }

        private void checkBoxExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExpense.Checked == false)
            {
                checkBoxIncome.Checked = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
