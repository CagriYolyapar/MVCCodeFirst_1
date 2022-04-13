using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class Order:BaseEntitiy
    {
        public string ShipAdress { get; set; }

        public int AppUserID { get; set; }

        //Relational Properties
        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}