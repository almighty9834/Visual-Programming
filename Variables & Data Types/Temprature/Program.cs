using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter farenheit into celcius:");

            Console.Write("\n");


            Console.Write(" Temprature in Farenheit: = ");
            
            double f = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            double c = (f - 32) * 0.5544;

            Console.Write("Tempraturre in Celcius: ="+c);

            
            Console.ReadLine();

        }
    }
}
