using System;
namespace Assignament1
{
    class q9
    {
        public static string reverseByWords(string Input)
        {
            char[] Array = Input.ToCharArray();
            string word = String.Empty;
            for (int i = Array.Length - 1; i > -1; i--)
            {
                word += Array[i];
            }
            return word;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseByWords("Jingle Bells Jingle Bells...Jingle On the way"));
            Console.WriteLine(reverseByWords("Liger is a movie and hero in the film is Vijay Devarakonda"));
        }
    }
}