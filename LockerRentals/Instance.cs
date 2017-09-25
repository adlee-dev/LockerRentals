using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    public class Instance
    {
        public DateTime EndDate { get; }
        public DateTime InstanceDateTime { get; }
        public bool IsCanceled { get; set; }
        
        // constructor for new instance
        public Instance(DateTime endDate)
        {
            EndDate = endDate;
            InstanceDateTime = DateTime.Now;
            IsCanceled = false;
        }

        // constructor for existing instance
        public Instance(DateTime endDate, DateTime instanceDateTime, bool isCanceled)
        {
            EndDate = endDate;
            InstanceDateTime = instanceDateTime;
            IsCanceled = isCanceled;
        }
    }
}
