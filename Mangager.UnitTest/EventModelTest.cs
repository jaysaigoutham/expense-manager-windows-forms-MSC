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
    public class EventModelTest
    {

        [TestMethod]
        public void ListEvenetsTest()
        {
            var data = new List<Manager.Event>
            {
                new Manager.Event { Id= 1, Name = "sample name 1", StartDate = DateTime.Now.Date},
                new Manager.Event { Id= 2, Name = "sample name 2", StartDate = DateTime.Now.Date},
                new Manager.Event { Id= 3, Name = "sample name 3", StartDate = DateTime.Now.Date}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Manager.Event>>();
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            mockContext.Setup(c => c.Events).Returns(mockSet.Object);



            Manager.Models.Event eventModel = new Manager.Models.Event(mockContext.Object);
            List<Manager.Event> result = eventModel.ListEvenets();

            Assert.AreEqual(data.Count<Event>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }

        [TestMethod]
        public void AddAppointmentTest()
        {
            //sample transaciton 
            Manager.Event eventObj = new Manager.Event();
            eventObj.Id = 1;
            eventObj.Name = "test tranaction 1";
            eventObj.StartDate = DateTime.Now.Date;
            eventObj.EventType = EventEnum.Appointment.ToString();


            var mockSet = new Mock<DbSet<Manager.Event>>();
            mockSet.Setup(c => c.Add(eventObj)).Returns(eventObj);

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Events).Returns(mockSet.Object);



            Manager.Models.Event eventModel = new Manager.Models.Event(mockContext.Object);
            bool result = eventModel.AddAppointment(eventObj);

            Assert.Equals(true, result);
        }

        public void AddTaskTest()
        {
            //sample transaciton 
            Manager.Event eventObj = new Manager.Event();
            eventObj.Id = 1;
            eventObj.Name = "test tranaction 1";
            eventObj.StartDate = DateTime.Now.Date;
            eventObj.EventType = EventEnum.Task.ToString();


            var mockSet = new Mock<DbSet<Manager.Event>>();
            mockSet.Setup(c => c.Add(eventObj)).Returns(eventObj);

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Events).Returns(mockSet.Object);



            Manager.Models.Event eventModel = new Manager.Models.Event(mockContext.Object);
            bool result = eventModel.AddTask(eventObj);

            Assert.Equals(true, result);
        }

        [TestMethod]
        public void getFilteredEventsTest()
        {
            var data = new List<Manager.Event>
            {
                new Manager.Event { Id= 1, Name = "sample name 1", StartDate = DateTime.Now.Date},
                new Manager.Event { Id= 2, Name = "sample name 2", StartDate = DateTime.Now.Date},
                new Manager.Event { Id= 3, Name = "sample name 3", StartDate = DateTime.Now.Date}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Manager.Event>>();
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Manager.Event>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            mockContext.Setup(c => c.Events).Returns(mockSet.Object);



            Manager.Models.Event eventModel = new Manager.Models.Event(mockContext.Object);
            List<Manager.Event> result = eventModel.ListEvenets();

            Assert.AreEqual(data.Count<Event>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(3, result[2].Id);
        }
    }
}
