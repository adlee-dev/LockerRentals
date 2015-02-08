using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRentals
{
    class Locker
    {
        private int locker;
        private string position;
        private string floor;
        private string combo;
        private string status;

        public Locker(int locker)
        {
            this.locker = locker;
            this.position = LockerPosition();

            Console.WriteLine(locker);
            Console.WriteLine(position);

        }

        private string LockerPosition()
        {
            string position = null;
            int remainder;

            remainder = (locker - 1) % 4;

            switch (remainder)
            {
                case 0:
                    position = "t";
                    break;
                case 1:
                    position = "mt";
                    break;
                case 2:
                    position = "mb";
                    break;
                case 3:
                    position = "b";
                    break;
            }

            return position;
        }
    }
}
