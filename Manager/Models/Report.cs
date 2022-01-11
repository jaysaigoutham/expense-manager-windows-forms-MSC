using Manager.Utillities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class Report
    {


        private DSFinance dsConection;
        private FinaceManagerADODBContainer managerDBEntities;

        public Report(DSFinance dsConection, FinaceManagerADODBContainer managerDBEntities)
        {
            this.dsConection = dsConection;
            this.managerDBEntities = managerDBEntities;
        }

        public List<Manager.Transaction> getReport(bool includeIncome, bool includeExpense, DateTime startDate, DateTime endDate)
        {

            List<Manager.Transaction> result = new List<Manager.Transaction>();

            try
            {
                //using (managerDBEntities)
                //{
                    managerDBEntities.Configuration.LazyLoadingEnabled = true;

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
                //}
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;


        }
    }
}
