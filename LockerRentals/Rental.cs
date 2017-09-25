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

        private List<Instance> instances = new List<Instance>();

        public int Id { get; }
        public DateTime StartDate { get; }
        public DateTime RentalDateTime { get; }
        public RentalStatus Status { get; set; }

        // constructor for new rental
        // add initial instance in separate action
        public Rental(int id, Locker locker, Renter renter)
        {
            this.locker = locker;
            this.renter = renter;

            Id = id;
            StartDate = DateTime.Now.Date;
            RentalDateTime = DateTime.Now;
            Status = RentalStatus.Active;   
        }

        // constructor for existing rental
        public Rental(int id, Locker locker, Renter renter, DateTime startDate, DateTime rentalDateTime, RentalStatus status, List<Instance> instances)
        {
            this.locker = locker;
            this.renter = renter;
            this.instances = instances;

            Id = id;
            StartDate = startDate;
            RentalDateTime = rentalDateTime;
            Status = status;
        }

    }
}
