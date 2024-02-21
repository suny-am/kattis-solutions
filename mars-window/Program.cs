using System;
using System.Linq;
using System.Reflection;

namespace MarsWindow
{
    static class Program
    {
        static void Main()
        {
            double year = double.Parse(Console.ReadLine());
            const double window = 26.0 / 12.0;
            double diffYears = year - (2017.0 + (4.0 / 12.0));

            string message = diffYears % window > 1 ? "no" : "yes";

            Console.WriteLine(message);
        }
    }
}