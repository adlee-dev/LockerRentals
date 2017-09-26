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
        private List<int> baseCombo;
        private string comboSetting;

        public int LockerNumber { get; }
        public string Floor { get; }
        public int SerialNumber { get; }
        public LockerStatus Status { get; set; }

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
        public Locker(int lockerNumber, string floor, List<int> baseCombo, string comboSetting, int serialNumber, LockerStatus status)
        {
            LockerNumber = lockerNumber;
            Floor = floor;
            this.baseCombo = baseCombo;
            this.comboSetting = comboSetting;
            SerialNumber = serialNumber;
            Status = status;
        }

        public void ChangeCombo(string newSetting)
        {
            this.comboSetting = newSetting;
        }
    }
}
