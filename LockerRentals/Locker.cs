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
        private int combo1;
        private int combo2;
        private int combo3;
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
        public Locker(int lockerNumber, string floor, int combo1, int combo2, int combo3, string comboSetting, int serialNumber, LockerStatus status)
        {
            LockerNumber = lockerNumber;
            Floor = floor;
            this.combo1 = combo1;
            this.combo2 = combo2;
            this.combo3 = combo3;
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
