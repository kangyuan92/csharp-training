using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class ConvertNumber
    {
        public String convert(int century)
        {
            int years = 100 * century;
            long days = 36524 * century;
            long hours = 876576 * century;
            long minutes = 52594560 * century;
            long seconds = 3155673600 * century;
            long milliseconds = 3155673600000 * century;
            long microseconds = 3155673600000000 * century;
            ulong nanoseconds = 3155673600000000000 * (ulong) century;

            return String.Format("{0} centuries = {1} years = {2} days = {3} hours = {4} " +
                "minutes = {5} seconds = {6} milliseconds = {7} " +
                "microseconds = {8} nanosecond", century, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
