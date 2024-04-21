using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Five-Digit");
            Console.WriteLine("\n");

            int a;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());

            int c;
            Console.WriteLine("Enter third number:");
            c = Convert.ToInt32(Console.ReadLine());

            int d;
            Console.WriteLine("Enter fourth number:");
            d = Convert.ToInt32(Console.ReadLine());

            int e;
            Console.WriteLine("Enter fifth number:");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result is:");
            Console.Write(e); Console.Write(d); Console.Write(c); Console.Write(b); Console.Write(a);  

            Console.ReadLine();
            
            
            

        }
    }
}
