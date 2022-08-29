using System;
namespace Assignament1
{
    class q2
    {
        static void Main(string[] args)
        {
            int [] arr= { 2, 5, 7, 4, 23, 46, 558, 79, 0 };
            int odd = 0;
            int even = 0;
            for (int i = 0;i <9;i++)
            {
                if (((arr[i])%2) == 0)
                {
                    even++;
                }
                else
                    odd++;
            }
            Console.WriteLine("The even numbers are:" + even);
            Console.WriteLine("The odd numbers are:" + odd);

        }
    }
}