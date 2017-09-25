using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    public enum RentalStatus
    {
        Active,
        Completed,
        Canceled,
        Transfered,
        Terminated
    }

    public class Rental
    {
        private Locker locker;
        private Renter renter;

        private List<Instance> instances = null;

        public DateTime StartDate { get; }
        public DateTime RentalDateTime { get; }
        public RentalStatus Status { get; }

        // constructor for new rental
        public Rental(Locker locker, Renter renter, DateTime endDate)
        {
            this.locker = locker;
            this.renter = renter;

            StartDate = DateTime.Now.Date;
            RentalDateTime = DateTime.Now;
            Status = RentalStatus.Active;

            instances.Add(new Instance(endDate));   
        }

        // constructor for existing rental
        public Rental(Locker locker, Renter renter, DateTime startDate, DateTime rentalDateTime, RentalStatus status, List<Instance> instances)
        {
            this.locker = locker;
            this.renter = renter;
            this.instances = instances;

            StartDate = startDate;
            RentalDateTime = rentalDateTime;
            Status = status;
        }

    }
}
