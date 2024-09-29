using Enums.Models;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=============== 1. Declaration =============");
            Console.WriteLine();

            //We declare a enum is WeekDay class
            //Printing a day from enum
            Days.Day today = Days.Day.Tuesday;
            Console.WriteLine(today);

            //Printing that value of day and converting into explicily int
            int DayValue = (int)today;
            Console.WriteLine(DayValue);
            Console.WriteLine();

            Console.WriteLine("Printing both days and its value ");
            //Iterating the enum which consist of Days and its int values
            foreach (Days.Day day in Enum.GetValues(typeof(Days.Day)))
            {
                Console.WriteLine($"{day} : {(int)day}");
            }
            Console.WriteLine();

            Console.WriteLine("============= 2. Printing the custom enum values =============");
            Console.WriteLine();

            //We can set the custom enum values
            foreach (Days.CustomDays day in Enum.GetValues(typeof(Days.CustomDays)))
            {
                Console.WriteLine($"{day} : {(int)day}");
            }
            Console.WriteLine();

            Console.WriteLine("============= 3. Using enum in method as switch =============");
            Console.WriteLine();


            // we have used the method and in that method we implemented a enum for a Week days
            Days.SwitchDays(Days.Day.Tuesday);
            Days.SwitchDays(Days.Day.Thursday);
            Days.SwitchDays(Days.Day.Saturday);
            Console.WriteLine();

            Console.WriteLine("============= 4. Flags Enum ==============");
            Console.WriteLine();
            
            Flag.Flags access = Flag.Flags.Read | Flag.Flags.Write;
            Console.WriteLine(Flag.Flags.Read);
            Console.WriteLine(Flag.Flags.Write);
            Console.WriteLine(access);
        }
    }
}
