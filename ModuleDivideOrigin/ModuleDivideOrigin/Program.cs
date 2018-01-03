using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModuleDivideOrigin
{
    internal static class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("I can check if firts number can be divided by second.");
            Console.WriteLine("Please enter fisrt number:");
            var first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            var second = Convert.ToDouble(Console.ReadLine());
            Divider(first, second);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void Divider (double a, double b)
        {
            Console.WriteLine(a%b == 0 ? "B is divider of A" : "B is not divider of A");
        }
}
}

