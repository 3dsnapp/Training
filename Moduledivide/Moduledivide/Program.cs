using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduledivide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can check if firts number can be divided by second.");
            Console.WriteLine("Please enter fisrt number:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double second = Convert.ToDouble(Console.ReadLine());

            void divider(double a, double b)
            {                               
                if (a % b == 0)
                {
                    Console.WriteLine("B is divider of A");
                }
                else
                {
                    Console.WriteLine("B is not divider of A");
                }
            }

            divider(first, second);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
