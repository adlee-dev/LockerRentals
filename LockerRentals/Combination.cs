using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this might be a good place for F# code

namespace LockerRentals
{
    public static class Combination
    {
        public static Tuple<int,int,int> GetCombo(Tuple<int,int,int> baseCombo, string comboSetting)
        {
            int offset = 0;

            switch (comboSetting)
            {
                case "A":
                    offset = 0;
                    break;
                case "B":
                    offset = 8;
                    break;
                case "C":
                    offset = 15;
                    break;
                case "D":
                    offset = 20;
                    break;
                case "E":
                    offset = 28;
                    break;
                // aka "F"
                default:
                    offset = 35;
                    break;
            }

            Tuple<int,int,int> rawCombo = Tuple.Create(baseCombo.Item1 + offset, baseCombo.Item2 + offset, baseCombo.Item3 + offset);
            return NormalizeCombo(rawCombo);
        }

        private static Tuple<int,int,int> NormalizeCombo(Tuple<int,int,int> rawCombo)
        {

        }
    }
}
