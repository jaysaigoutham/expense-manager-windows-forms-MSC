using Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangager.UnitTest
{
    [TestClass]
    public class FinanceModelTest
    {
        [TestMethod]
        public void getFilteredIncomeTransactionTest()
        {
            var data = new List<Manager.Transaction>
            {
                new Manager.Transaction { Id= 1, Name = "sample name 1", Date = DateTime.Now.Date},
                new Manager.Transaction { Id= 2, Name = "sample name 2", Date = DateTime.Now.Date},
                new Manager.Transaction { Id= 3, Name = "sample name 3", Date = DateTime.Now.Date}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Manager.Transaction>>();
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Transactions).Returns(mockSet.Object);



            Manager.Models.Transaction transactionModel = new Manager.Models.Transaction(mock1.Object, mockContext.Object);
            List<Manager.Transaction> result = transactionModel.getAllTransactions();

            Assert.AreEqual(data.Count<Transaction>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }

        [TestMethod]
        public void getFilteredExpenseTransactionTest()
        {
            var data = new List<Manager.Transaction>
            {
                new Manager.Transaction { Id= 1, Name = "sample name 1", Date = DateTime.Now.Date},
                new Manager.Transaction { Id= 2, Name = "sample name 2", Date = DateTime.Now.Date},
                new Manager.Transaction { Id= 3, Name = "sample name 3", Date = DateTime.Now.Date}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Manager.Transaction>>();
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Manager.Transaction>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Transactions).Returns(mockSet.Object);



            Manager.Models.Transaction transactionModel = new Manager.Models.Transaction(mock1.Object, mockContext.Object);
            List<Manager.Transaction> result = transactionModel.getAllTransactions();

            Assert.AreEqual(data.Count<Transaction>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }
    }
}
