using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class Product:BaseEntitiy
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryID { get; set; }

        //Relitional Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}