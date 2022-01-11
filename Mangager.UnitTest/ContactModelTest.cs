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
    public class ContactModelTest
    {

        [TestMethod]
        public void ListContactsTest()
        {
            var data = new List<Manager.Contact>
            {
                new Manager.Contact { Id= 1, Name = "sample name 1", Date = DateTime.Now.Date},
                new Manager.Contact { Id= 2, Name = "sample name 2", Date = DateTime.Now.Date},
                new Manager.Contact { Id= 3, Name = "sample name 3", Date = DateTime.Now.Date}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Manager.Contact>>();
            mockSet.As<IQueryable<Manager.Contact>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Manager.Contact>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Manager.Contact>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Manager.Contact>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);



            Manager.Models.Contact contactModel = new Manager.Models.Contact( mockContext.Object);
            List<Manager.Contact> result = contactModel.ListContacts();

            Assert.AreEqual(data.Count<Contact>(), result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
        }

        [TestMethod]
        public void AddContactTest()
        {
            //sample transaciton 
            Manager.Contact contact = new Contact();
            contact.Id = 1;
            contact.Name = "test tranaction 1";
            contact.Date = DateTime.Now.Date;


            var mockSet = new Mock<DbSet<Manager.Contact>>();
            mockSet.Setup(c => c.Add(contact)).Returns(contact);

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);



            Manager.Models.Contact contactModel = new Manager.Models.Contact(mockContext.Object);
            bool result = contactModel.AddContact(contact);

            Assert.Equals(true, result);
        }

        [TestMethod]
        public void UpdateContactTest()
        {
            //sample transaciton 
            Manager.Contact contact = new Contact();
            contact.Id = 1;
            contact.Name = "test tranaction 1";
            contact.Date = DateTime.Now.Date;


            var mockSet = new Mock<DbSet<Manager.Contact>>();
            mockSet.Setup(c => c.Add(contact)).Returns(contact);

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);



            Manager.Models.Contact contactModel = new Manager.Models.Contact(mockContext.Object);
            bool result = contactModel.AddContact(contact);

            Assert.Equals(true, result);
        }

        [TestMethod]
        public void DeleteContactTest()
        {
            //sample transaciton 
            Manager.Contact contact = new Contact();
            contact.Id = 1;
            contact.Name = "test tranaction 1";
            contact.Date = DateTime.Now.Date;


            var mockSet = new Mock<DbSet<Manager.Contact>>();
            mockSet.Setup(c => c.Remove(contact)).Returns(contact);

            var mockContext = new Mock<FinaceManagerADODBContainer>();
            var mock1 = new Mock<DSFinance>();
            mockContext.Setup(c => c.Contacts).Returns(mockSet.Object);



            Manager.Models.Contact contactModel = new Manager.Models.Contact( mockContext.Object);
            bool result = contactModel.UpdateContact(contact);

            Assert.Equals(true, result);
        }

     }
 }
