using System;
namespace Assignament1
{
    class q4
    {
        static void Main(string[] args)
        {
            int[] res = { 0, 0 };
            int[] ar1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int lengthOfar1 = ar1.Length;
            for (int i = 0; i <ar1.Length; i++)
            {
                if (ar1[i] % 2 == 0)
                {
                    res[0] += ar1[i];
                }
                else if (ar1[i] % 2 != 0)
                {
                    res[1] += ar1[i];
                }
                else
                {
                    res[0] += 0;
                    res[1] += 0;
                }
            }
            Console.WriteLine("The sum of even numbers are:"+res[0]);
            Console.WriteLine("The sum of odd numbers are:"+res[1]);

            

            //SumOfOdd();
            //SumOfEven();
        }

        //private static void SumOfEven()
        //{

        //}

        //private static void SumOfOdd()
        //{
        //    ;
        //}
    }
}