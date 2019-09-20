using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDAL
{
    public class DB
    {
        public static int lastId = 0;
        public static List<User> contactList = new List< User > ();
        public static List<User> sortedContactList = new List<User>();
    }
}
