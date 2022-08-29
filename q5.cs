using System;

namespace Assignament1
{
    class q5
    {
        static void Main(string[] args)
        {
            SimpleInterest();
        }
        private static void SimpleInterest()
        {
            Console.WriteLine("Enter Principle Amount");
            double Principle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest");
            double ROI = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time period");
            double time = double.Parse(Console.ReadLine());
            double SI = new double();
            SI = Principle * (1 + (ROI * time));
            Console.WriteLine(SI);
        }
    }
}