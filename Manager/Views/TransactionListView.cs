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
    public partial class TransactionListView : Form
    {

        private Models.Transaction transactionModel;
        List<Manager.Transaction> transactions;

        public TransactionListView()
        {
            InitializeComponent();
            listViewTransactions.MouseDown += ListViewTransactions_MouseDown;
            listViewTransactions.MouseUp += ListViewTransactions_MouseUp;



            listViewTransactions.AllowColumnReorder = false;
            listViewTransactions.AllowDrop = false;
            this.listViewTransactions.LostFocus += (s, e) => this.listViewTransactions.SelectedIndices.Clear();
        }

        private void ListViewTransactions_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void ListViewTransactions_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var info = listViewTransactions.HitTest(e.X, e.Y);
                var row = info.Item.Index;
                var col = info.Item.SubItems.IndexOf(info.SubItem);
                var value = info.Item.SubItems[col].Text;
                //MessageBox.Show(string.Format("R{0}:C{1} val '{2}'", row, col, value));
                listViewTransactions.SelectedItems.Clear();


                if (col == 5)
                {
                    delete(row);
                }

                if (col == 4)
                {
                    openUpdate(row);
                }

                return;
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Unable to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void delete(int row)
        {

            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                deleteTransactionAsync(row);
            }
        }

        private async Task deleteTransactionAsync(int row)
        {
            bool result = await Task.Run(() => transactionModel.deleteTransaction(transactions.ElementAt(row)));
            if(result)
            {
                MessageBox.Show("Deleted transaction", "Deleted !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearListview();
                setupListView();
                loadTranscations();
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }

        private void openUpdate(int row)
        {
            Manager.Transaction selectedTransaction = transactions.ElementAt(row);
            UpdateTransactionView updateTransactionView = new UpdateTransactionView(selectedTransaction);
            updateTransactionView.NotifyParent += UpdateTransactionView_NotifyParent; ;
            updateTransactionView.Activate();
            updateTransactionView.ShowDialog();
        }

        private void UpdateTransactionView_NotifyParent(string message)
        {
            if(message.Equals(Properties.Resources.RELOAD))
            {
                clearListview();
                setupListView();
                loadTranscations();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Point mousePos = listViewTransactions.PointToClient(Control.MousePosition);
            //ListViewHitTestInfo hitTest = listViewTransactions.HitTest(mousePos);
            //int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
        }

        private void TransactionListView_Load(object sender, EventArgs e)
        {

            transactionModel = new Models.Transaction(new DSFinance(), new FinaceManagerADODBContainer());
            setupListView();
            loadTranscations();

        }

        private void setupListView()
        {
            listViewTransactions.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Type", 80, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Payer", 100, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Date", 80, HorizontalAlignment.Left);
            listViewTransactions.Columns.Add("Update", 50, HorizontalAlignment.Center);
            listViewTransactions.Columns.Add("Delete", 50, HorizontalAlignment.Center);
            listViewTransactions.MultiSelect = false;
            listViewTransactions.FullRowSelect = true;
            listViewTransactions.View = View.Details;
            listViewTransactions.Activation = ItemActivation.OneClick;
            listViewTransactions.LabelEdit = true;
        }

        private void clearListview()
        {
            listViewTransactions.Clear();
        }

        private void loadTranscations()
        {
            try
            {
                transactions = transactionModel.getAllTransactions();
                foreach (Manager.Transaction transaction in transactions)
                {
                    ListViewItem lvi = new ListViewItem(transaction.Name);
                    if (transaction.TransactionType == Utillities.TransactionEnum.Income.ToString())
                    {
                        lvi.SubItems.Add("Income");
                    }
                    else
                    {
                        lvi.SubItems.Add("Expense");
                    }
                    if (transaction.Contact != null)
                    {
                        if (transaction.Contact.Name != null)
                        {
                            lvi.SubItems.Add(transaction.Contact.Name.ToString());
                        }
                        else
                        {
                            lvi.SubItems.Add(string.Empty);
                        }

                    }
                    else
                    {
                        lvi.SubItems.Add(string.Empty);
                    }

                    lvi.SubItems.Add(transaction.Date.ToString("MMMM dd yyyy"));
                    lvi.SubItems.Add("update");
                    lvi.SubItems.Add("X");
                    lvi.UseItemStyleForSubItems = false;

                    listViewTransactions.Items.Add(lvi);
                }

                // Custom Method
                ChangeToUnderline(ref listViewTransactions, 4, Color.Blue);
                ChangeToUnderline(ref listViewTransactions, 5, Color.Red);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please restart the view ", "Someting went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
