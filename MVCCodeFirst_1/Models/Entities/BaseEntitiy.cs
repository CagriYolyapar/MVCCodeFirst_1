using MVCCodeFirst_1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public abstract class BaseEntitiy
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus? Status { get; set; }

        public BaseEntitiy()
        {
            CreatedDate = DateTime.Now;
            Status = Enums.DataStatus.Inserted;
        }
    }
}