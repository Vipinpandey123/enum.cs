using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Months
        {
            January = 1, February, March, April,
            May, June, July, August = 108,
            September, October, November, December
        };
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("The {0}th month of the year is {1}", (int)Months.August, Months.August);

            foreach (Months e in Enum.GetValues(typeof(Months)))
            {
                count++;
                Console.Write("Month " + (int)e + "...");
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}
