using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class AppUser:BaseEntitiy
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}