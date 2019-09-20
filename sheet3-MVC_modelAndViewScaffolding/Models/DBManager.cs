using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactBAL;
using Entities;

namespace sheet3_MVC_modelAndViewScaffolding.Models
{
    public class DBManager
    {
        //instantiate the class that contains the methods to manipulate the DB
        BAL bal = new BAL();

        public void addRecord(User u) {
            bal.addRecord(u);
        }
        public void editRecord(User u) {
            bal.editRecord(u);
        }
        public void deleteRecord(User u) {
            bal.Delete(u);
        }

        public List <User> getAll() {
            return bal.showList();
        }
        public User details(int id) {
            return bal.details(id);
        }
    }
}