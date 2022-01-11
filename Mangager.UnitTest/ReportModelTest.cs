using Manager;
using Manager.Utillities;
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
    public class ReportModelTest
    {

        //Test both income & expense
        [TestMethod]
        public void getReport1()
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



            Manager.Models.Report reportModel = new Manager.Models.Report(mock1.Object, mockContext.Object);
            List<Manager.Transaction> result = reportModel.getReport(true, true, DateTime.Now.Date, DateTime.Now.Date);

            Assert.AreEqual(data.Count<Transaction>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }

        //Test only income
        [TestMethod]
        public void getReport2()
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
            mockContext.Setup(c => c.Transactions.Where(x => x.TransactionType == TransactionEnum.Income.ToString())).Returns(mockSet.Object);



            Manager.Models.Report reportModel = new Manager.Models.Report(mock1.Object, mockContext.Object);
            List<Manager.Transaction> result = reportModel.getReport(true, false, DateTime.Now.Date, DateTime.Now.Date);

            Assert.AreEqual(data.Count<Transaction>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }


        //Test only expense
        [TestMethod]
        public void getReport3()
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



            Manager.Models.Report reportModel = new Manager.Models.Report(mock1.Object, mockContext.Object);
            List<Manager.Transaction> result = reportModel.getReport(false, true, DateTime.Now.Date, DateTime.Now.Date);

            Assert.AreEqual(data.Count<Transaction>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }
    }
}
