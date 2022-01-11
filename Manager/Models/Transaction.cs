using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Threading;
using Manager.Utillities;

namespace Manager.Models
{
    public class Transaction
    {
        private DSFinance dsConection = new DSFinance();
        private FinaceManagerADODBContainer managerDBEntities;

        public Transaction(DSFinance dsConection, FinaceManagerADODBContainer managerDBEntities)
        {
            this.dsConection = dsConection;
            this.managerDBEntities = managerDBEntities;
        }

        public List<Manager.Transaction> getAllTransactions()
        {
            List<Manager.Transaction> transactions = new List<Manager.Transaction>();

            try {

                /*using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    managerDBEntities.Configuration.LazyLoadingEnabled = true;
                    transactions = managerDBEntities.Transactions.ToList();
                    Thread.Sleep(1000);
                }*/

                //FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer();
                managerDBEntities.Configuration.LazyLoadingEnabled = true;
                transactions = managerDBEntities.Transactions.ToList();

                //managerDBEntities.Dispose();
            }
            catch (Exception ex)
            {
                //return transactions;
                //Error occured
            }
            

          

            return transactions;
        }

        

        

        public bool AddTransaction(Manager.Transaction transaction)
        {
            try
            {

                using (managerDBEntities)
                {
                    /*Manager.Transaction newTransaction = new Manager.Transaction();
                    newTransaction.Name = transaction.TransactionName;
                    newTransaction.TransactionType = transaction.TransactionType.ToString();
                    newTransaction.Amount = transaction.Amount;
                    newTransaction.Date = transaction.TransactionDate;
                    newTransaction.Comment = transaction.Comment;

                    if (transaction.Contact != null)
                    {
                        Manager.Contact newContact = new Manager.Contact();
                        newContact.Id = transaction.Contact.ContactId;
                        newContact.Name = transaction.Contact.ContactName;
                        newContact.PhoneNumber =  transaction.Contact.ContactPhoneNo;
                        newContact.Comment = transaction.Contact.Comment;

                        newTransaction.Contact = newContact;
                    }
                    else
                    {
                        newTransaction.Contact = null;
                    }*/

                    if (transaction.Contact != null)
                    {
                        var resultContact = managerDBEntities.Contacts.SingleOrDefault(b => b.Id == transaction.Contact.Id);
                        transaction.Contact = resultContact;
                    }
                    else
                    {
                        transaction.Contact = null;
                    }

                    managerDBEntities.Transactions.Add(transaction);
                    managerDBEntities.SaveChanges();

                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool updateTransaction(Manager.Transaction transaction)
        {
            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    var result = managerDBEntities.Transactions.SingleOrDefault(b => b.Id == transaction.Id);
                    
                    if (result != null)
                    {
                        result.Name = transaction.Name;
                        result.TransactionType = transaction.TransactionType;
                        result.Comment = transaction.Comment;
                        result.Amount = transaction.Amount;
                        result.Date = transaction.Date;
                        if (transaction.Contact != null)
                        {
                            var resultContact = managerDBEntities.Contacts.SingleOrDefault(b => b.Id == transaction.Contact.Id);
                            result.Contact = resultContact;
                        }
                        else
                        {
                            result.Contact = null;
                        }
                        //managerDBEntities.Transactions.AddOrUpdate(result);
                        managerDBEntities.SaveChanges();
                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool deleteTransaction(Manager.Transaction transaction)
        {
            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    var result = managerDBEntities.Transactions.SingleOrDefault(b => b.Id == transaction.Id);
                    if (result != null)
                    {
                        managerDBEntities.Transactions.Remove(result);
                        managerDBEntities.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Manager.Transaction> getFilteredTransaction(bool includeIncome, bool includeExpense, DateTime startDate, DateTime endDate)
        {

            List<Manager.Transaction> result = new List<Manager.Transaction>();

            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                   

                    if (includeIncome && !includeExpense)
                    {
                        result = managerDBEntities.Transactions
                        .Where(x => x.TransactionType == TransactionEnum.Income.ToString() &&
                        x.Date >= startDate && x.Date <= endDate).ToList();
                    }
                    else if (!includeIncome && includeExpense)
                    {
                        result = managerDBEntities.Transactions
                        .Where(x => x.TransactionType == TransactionEnum.Expense.ToString() &&
                        x.Date >= startDate && x.Date <= endDate).ToList();
                    }
                    else
                    {
                        result = managerDBEntities.Transactions
                        .Where(x => x.Date >= startDate && x.Date <= endDate).ToList();
                    }
                       

                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;


        }
    }
}
