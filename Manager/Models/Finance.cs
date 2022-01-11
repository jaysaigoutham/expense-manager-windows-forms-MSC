using Manager.Utillities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class Finance
    {
        private DSFinance dsConection = new DSFinance();

        public List<Manager.Transaction> getFilteredIncomeTransaction(DateTime date)
        {

            List<Manager.Transaction> results = new List<Manager.Transaction>();

            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    results = managerDBEntities.Transactions
                       .Where(x => x.TransactionType == TransactionEnum.Income.ToString() &&
                       x.Date == date).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return results;
        }


        public List<Manager.Transaction> getFilteredExpenseTransaction(DateTime date)
        {
            List<Manager.Transaction> results = new List<Manager.Transaction>();

            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    results = managerDBEntities.Transactions
                       .Where(x => x.TransactionType == TransactionEnum.Expense.ToString() &&
                       x.Date == date).ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return results;
        }
    }
}
