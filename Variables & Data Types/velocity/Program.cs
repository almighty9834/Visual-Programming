using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter initial velocity(vi): ");
            double vi = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Enter time (t): ");
            double t = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter acceleration (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            
            double s = vi * t + 0.5 * a * 2;

            
            Console.WriteLine("Distance covered by the car :"+s);

            Console.ReadLine(); 
        }
    }
}
