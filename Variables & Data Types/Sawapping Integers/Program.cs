using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sawapping Integers");
            Console.WriteLine("\n");

            Console.Write("Enter 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter 3rd number:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Value of 1st before swapping ="+a);
            Console.WriteLine("Value of 2nd before swapping ="+b);
            Console.WriteLine("Value of 3rd before swapping ="+c);

             Console.WriteLine("\n");

            Console.WriteLine("Value of 1st after swapping ="+b);
            Console.WriteLine("Value of 2nd after swapping ="+c);
            Console.WriteLine("Value of 3rd after swapping ="+a);

            Console.ReadLine();

        }
    }
}
