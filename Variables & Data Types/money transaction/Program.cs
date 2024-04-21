using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM Machine!");
            Console.WriteLine("\n");

            Console.Write("Enter the amount to withdraw (in PAK rupees): ");

            Console.WriteLine("Enter your Amount");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The ATM Machine order will be:");
            int a = m / 5000;
            int aa = m % 5000;
            Console.WriteLine("Notes of 5000  => " + a);

            int b = m / 1000;
            int bb = m % 1000;
            Console.WriteLine("Notes of 1000 => " + b);

            int c = m / 500;
            int cc = m % 500;
            Console.WriteLine("Notes of  500  => " + c);

            int d = m / 100;
            int dd = m % 100;
            Console.WriteLine("Notes of  100  => " + d);

            int e = m / 50;
            int ee = m % 50;
            Console.WriteLine("Notes of   50  => " + e);

            int f = m / 20;
            int ff = m % 20;
            Console.WriteLine("Notes of   20  => " + f);

            int g = m / 10;
            int gg = m % 10;
            Console.WriteLine("Notes of   10  => " + g);

            int h = m / 5;
            int hh = m % 5;
            Console.WriteLine("Notes of    5  => " + h);

            int i = m/ 2;
            int ii = m  % 2;
            Console.WriteLine("Notes of    2  => " + i);

            int j = m / 1;
            int jj = m % 1;
            Console.WriteLine("Notes of    1  => " + j);


            Console.ReadLine();
        }
    }
}
