using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping two numbers:");
            Console.WriteLine("\n");

            Console.WriteLine("Enter 1st number\t:a");
            int a = Convert.ToInt32("500");


            Console.WriteLine("Enter 2nd number\t:b");
            int b = Convert.ToInt32("100");

            Console.WriteLine("\n");

            Console.WriteLine("Value of a before swapping is = "+a);
            Console.WriteLine("Value of b before swapping is = "+b);

            Console.WriteLine("\n");

            Console.WriteLine("Vale of  a after swapping: "+b);
            Console.WriteLine("Vale of  b after swapping: "+a);

            Console.ReadLine();
        }
    }
}
