using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    public enum LockerStatus
    {
        Available,
        Rented,
        Maintenance,
        OutOfService
    }

    public class Locker
    {
        public int LockerNumber { get; }
        public string Floor { get; }
        public string Combo { get; }
        public int SerialNumber { get; }
        public LockerStatus Status { get; }

        public string Position
        {
            get
            {
                switch ((LockerNumber - 1) % 4)
                {
                    case 0:
                        return "t";
                    case 1:
                        return "mt";
                    case 2:
                        return "mb";
                    default:
                        return "b";
                }
            }
        }

        // constructor for existing locker
        public Locker(int lockerNumber, string floor, string combo, int serialNumber, LockerStatus status)
        {
            LockerNumber = lockerNumber;
            Floor = floor;
            Combo = combo;
            SerialNumber = serialNumber;
            Status = status;
        }
    }
}
