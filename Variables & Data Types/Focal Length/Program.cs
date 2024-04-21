using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Printing the Focal Length:");
            Console.WriteLine("\n");


            Console.Write("Distance of object from lense\t:");
            double p = Convert.ToDouble(Console.ReadLine());


            Console.Write("Distance of image from lense\t:");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n"); 

            double s = (1/p) + (1/q);
            double f = 1 / s;
            Console.WriteLine("Focal Length of lens = "+f);


            Console.ReadLine();

        }
    }
}
