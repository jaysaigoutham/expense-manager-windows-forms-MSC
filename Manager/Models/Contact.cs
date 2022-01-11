using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class Contact
    {
        private FinaceManagerADODBContainer managerDBEntities;
        public Contact(FinaceManagerADODBContainer managerDBEntities)
        {
            this.managerDBEntities = managerDBEntities;
        }


        public List<Manager.Contact> ListContacts()
        {
            List<Manager.Contact> contacts = new List<Manager.Contact>();

            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    contacts = managerDBEntities.Contacts.ToList();
                }
                
            }
            catch (Exception ex)
            {
                return contacts;
            }

            return contacts;
        }

        public bool AddContact(Manager.Contact contact)
        {

            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    managerDBEntities.Contacts.Add(contact);
                    managerDBEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool AddMultipleContacts(List<Manager.Contact> contacts)
        {
            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    managerDBEntities.Contacts.AddRange(contacts);
                    managerDBEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateContact(Manager.Contact contact)
        {

            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {

                    var result = managerDBEntities.Contacts.SingleOrDefault(b => b.Id == contact.Id);
                    if (result != null)
                    {
                        managerDBEntities.Contacts.AddOrUpdate(contact);
                        managerDBEntities.SaveChanges();
                    }
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
