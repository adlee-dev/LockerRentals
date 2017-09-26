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
        public static List<int> GetCombo(List<int> baseCombo, string comboSetting)
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

            IEnumerable<int> rawCombo = baseCombo.Select(item => item + offset);
            return NormalizeCombo(rawCombo);
        }

        private static List<int> NormalizeCombo(IEnumerable<int> rawCombo)
        {
            List<int> output = new List<int>();

            foreach (int value in rawCombo) {
                if (value >= 40)
                {
                    output.Add(value - 40);
                }
                else
                {
                    output.Add(value);
                }
            }

            return output;
        }
    }
}
