using System;
namespace Assignament1
{
    class q6
    {
        private static bool IsValidDate(int year, int month, int day)
        {
            if (year % 4 == 0 && month == 2 && day < 29)
            {
                Console.WriteLine("The date is validated");
                return true;
            }
            else if (month < 13 && day<31)
                {
                Console.WriteLine("The date is validated");
                return true;
            }
            else
                Console.WriteLine("The date is invalid");
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The year is:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("The month is:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("The day is:");
            int day = int.Parse(Console.ReadLine());
            IsValidDate( year, month, day);
        }
    }
}