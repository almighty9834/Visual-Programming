using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            Console.Write("Enter distance in kilometer:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            double m;
            m = a * 1000;
            Console.Write("distance in meter\t= " + m);

            double cm;
            cm = a * 10000;
            Console.WriteLine("distance in centi-meter\t= " + cm);


            double ft;
            ft = a *2000;
            Console.WriteLine("distance in feet\t= " + ft);


            double inch;
            inch = a * 2999.1;
            Console.WriteLine("distance in inches\t= " + inch);


            Console.ReadLine();
        }
    }
}
