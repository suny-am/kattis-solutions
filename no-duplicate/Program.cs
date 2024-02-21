using System;

namespace NoDuplicate
{
    static class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            if (input!.Distinct().Count() != input!.Length)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}