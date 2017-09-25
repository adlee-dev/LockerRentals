using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    public class Instance
    {
        public int Id { get; }
        public DateTime EndDate { get; }
        public DateTime InstanceDateTime { get; }
        public bool IsCanceled { get; set; }
        
        // constructor for new instance
        public Instance(int id, DateTime endDate)
        {
            Id = id;
            EndDate = endDate;
            InstanceDateTime = DateTime.Now;
            IsCanceled = false;
        }

        // constructor for existing instance
        public Instance(int id, DateTime endDate, DateTime instanceDateTime, bool isCanceled)
        {
            Id = id;
            EndDate = endDate;
            InstanceDateTime = instanceDateTime;
            IsCanceled = isCanceled;
        }


    }
}
