using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Five numbers:");
            Console.WriteLine("\n");

            Console.Write("Enter 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter 3rd number:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 4th number:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 5th number:");
            int e = Convert.ToInt32(Console.ReadLine()); 

            int sum = a + b + c + d + e;
            Console.WriteLine("\n");
            Console.WriteLine("Sum of all Numbers is= "+sum);


            Console.ReadLine();
        }
    }
}
