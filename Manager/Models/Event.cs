using Manager.Utillities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Models
{
    public class Event
    {
        private FinaceManagerADODBContainer managerDBEntities;
        public Event(FinaceManagerADODBContainer managerDBEntities)
        {
            this.managerDBEntities = managerDBEntities;
        }

        public List<Manager.Event> ListEvenets()
        {
            List<Manager.Event> events = new List<Manager.Event>();

            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    events = managerDBEntities.Events.ToList();
                }

            }
            catch (Exception ex)
            {
            }

            return events;
        }

        public bool AddTask(Manager.Event task)
        {

            try
            {

                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {

                    if (task.Contact != null)
                    {
                        var resultContact = managerDBEntities.Contacts.SingleOrDefault(b => b.Id == task.Contact.Id);
                        task.Contact = resultContact;
                    }
                    else
                    {
                        task.Contact = null;
                    }

                    managerDBEntities.Events.Add(task);
                    managerDBEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddAppointment(Manager.Event appointment)
        {

            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {
                    if (appointment.Contact != null)
                    {
                        var resultContact = managerDBEntities.Contacts.SingleOrDefault(b => b.Id == appointment.Contact.Id);
                        appointment.Contact = resultContact;
                    }
                    else
                    {
                        appointment.Contact = null;
                    }


                    managerDBEntities.Events.Add(appointment);
                    managerDBEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Manager.Event> getFilteredEvents(bool includeTask, bool includeAppointmrnt, DateTime startDate, DateTime endDate)
        {
            List<Manager.Event> result = new List<Manager.Event>();

            try
            {
                using (FinaceManagerADODBContainer managerDBEntities = new FinaceManagerADODBContainer())
                {


                    if (includeTask && !includeAppointmrnt)
                    {
                        result = managerDBEntities.Events
                        .Where(x => x.EventType == EventEnum.Task.ToString() &&
                        x.StartDate >= startDate && x.EndDate <= endDate).ToList();
                    }
                    else if (!includeTask && includeAppointmrnt)
                    {
                        result = managerDBEntities.Events
                        .Where(x => x.EventType == EventEnum.Appointment.ToString() &&
                        x.StartDate >= startDate && x.EndDate <= endDate).ToList();
                    }
                    else
                    {
                        result = managerDBEntities.Events
                        .Where(x => x.StartDate >= startDate ||  x.EndDate <= endDate)
                        .ToList();
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
