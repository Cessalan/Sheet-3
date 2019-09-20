using ContactDAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactBAL
{
    public class BAL
    {
        public void addRecord(User u) {
            u.Id = DB.lastId++;
            DB.contactList.Add(u);
        }
        public void editRecord(User u) {
            var tempRecord = DB.contactList.Where(selectedRec => selectedRec.Id == u.Id).Single();
            tempRecord.Id = u.Id;
            tempRecord.firstName = u.firstName;
            tempRecord.lastName = u.lastName;
            tempRecord.mobilePhone = u.mobilePhone;
            tempRecord.homePhone = u.homePhone;
            tempRecord.businessPhone = u.businessPhone;
            tempRecord.address = u.address;
            tempRecord.notes = u.notes;
            tempRecord.active = u.active;
            }

        public void Delete(User u) {
            var tempRecord = DB.contactList.Where(selectedRec => selectedRec.Id ==u.Id).Single();
            tempRecord.Id = u.Id;
            tempRecord.firstName = u.firstName;
            tempRecord.lastName = u.lastName;
            tempRecord.mobilePhone = u.mobilePhone;
            tempRecord.homePhone = u.homePhone;
            tempRecord.businessPhone = u.businessPhone;
            tempRecord.address = u.address;
            tempRecord.notes = u.notes;
            tempRecord.active = false;
            

        }

        public List<User> showList() {
            foreach (User user in DB.contactList)
            {
                if (user.active)
                {
                    if(!DB.sortedContactList.Contains(user))
                    DB.sortedContactList.Add(user);
                }
            }
            return DB.sortedContactList;

        }

        public User details(int id) {
            return DB.contactList.Where(rec=>rec.Id==id).Single();
        }
    }
}
