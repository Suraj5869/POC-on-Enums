using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Models
{
    internal class Days
    {
        //enums of days
        public enum Day {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        //enums with custom values
        public enum CustomDays
        {
            Sunday = 1, Monday = 5, Tuesday, Wednesday = 9, Thursday, Friday=15, Saturday
        }


        //switch case to use Enum
        public static void SwitchDays(Day day )
        {
            switch (day)
            {
                case Day.Monday:
                    Console.WriteLine("It's Monday!");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("It's Tuesday!");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("It's Wednesday!");
                    break;
                case Day.Thursday:
                    Console.WriteLine("It's Thhursday!");
                    break;
                case Day.Friday:
                    Console.WriteLine("It's Friday!");
                    break;
                case Day.Saturday:
                    Console.WriteLine("It's Saturday!");
                    break;
                case Day.Sunday:
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine("It's just another day!");
                    break;
            }
        }
}
}
