using System;
namespace Assignament1
{
    class q3
    {
        static void Main(string[] args)
        {
            int Result=0;
            RETRY:
            Console.WriteLine("Enter the value 1");
            int val1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the value 2");
            int val2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operator: +, -, *, or /");
            char Operator=char.Parse(Console.ReadLine());
            switch(Operator)
            {
                case '+':
                    Result = val1 + val2;
                    break;
                case '-':
                    Result = val1 - val2;
                    break;
                case '*':
                    Result = val1 * val2;
                    break;
                case '/':
                    Result = val1 / val2;
                    break;
                default:
                    Result=0;
                    return;
                    
            }
            Console.WriteLine("The value is "+Result);
            goto RETRY;
        }
    }
}