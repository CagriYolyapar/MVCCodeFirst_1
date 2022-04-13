using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class OrderDetail:BaseEntitiy
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual  Order Order { get; set; }

    }
}