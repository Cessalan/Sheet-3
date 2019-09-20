using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private Boolean isActive = true;
        public int Id { set; get; }
        public String firstName{set;get;}
        public String lastName { set; get; }
        public String mobilePhone { set; get; }
        public String homePhone { set; get; }
        public String businessPhone { set; get; }
        public String address { set; get; }
        public String notes { set; get; }
        public Boolean active { set; get; }
        
        

    }
}
