using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROBLEM #03");
            Console.WriteLine("\n");
            Console.WriteLine("Ayesha Mukhtar");
            Console.WriteLine("Roll#14");
            Console.WriteLine("\n");


            double basicsalary; 
            Console.Write("Basic salary of employe:");
            basicsalary = Convert.ToDouble(Console.ReadLine());

            double hra, ma, ta, itd, gd;

            if (basicsalary >= 50000)
            {
                hra = 15 * basicsalary;
                ma = 25 * basicsalary;
                ta = 2500;
                itd = 6 * (basicsalary + hra + ma + ta);
                gd = 4.8 * (basicsalary + hra + ma + ta);

            }

            else if (basicsalary >= 25000 && basicsalary <= 50000)
            {
                hra = 10 * basicsalary;
                ma = 20 * basicsalary;
                ta = 2500;
                itd = 5 * (basicsalary + hra + ma + ta);
                gd = 4.5 * (basicsalary + hra + ma + ta);
            }

            else if (basicsalary>= 10000 && basicsalary <= 25000)
            {
                hra = 5 * basicsalary;
                ma = 20 * basicsalary;
                ta = 2000;
                itd = 1000;
                gd = 500;

            }


            else
            {
                hra = 0;
                ma = 15 * basicsalary;
                ta = 1500;
                itd = 500;
                gd = 200;
                
            }


            double groossalary = basicsalary + hra + ma + ta;
            double netsalary = groossalary - itd - gd;

            Console.WriteLine("Gross salary=\t  " + groossalary);
            Console.WriteLine("Income tax deduCtion=\t"+ itd);
            Console.WriteLine("Net salary =\t  " + netsalary);

            Console.ReadLine();
        }
    }
}
