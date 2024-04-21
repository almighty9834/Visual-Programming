using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROBLEM 1 ");
            Console.WriteLine("\n ");
            Console.WriteLine("Ayesha Mukhtar ");
            Console.WriteLine("Roll # 14");
            
            int a, b, c;

            Console.WriteLine("\n");

            Console.Write("input value a\t=");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("input value b\t= ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("input value c\t=");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ");
            double d, x1, x2;
            d = (b * b) - (4 * a * c);

            if (d == 0)
            {
                Console.WriteLine("Both root are Equal");
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("the 1st root ={0}", x1);
                Console.WriteLine("the 2nd root ={1}", x2);
            }
            else if (d > 0)
            {
                x1 = -b + Math.Sqrt(d) / (2 * a);
                x2 = -b - Math.Sqrt(d) / (2 * a);
                Console.WriteLine("Given root are Real:");
                Console.WriteLine("1st root={0}", x1);
                Console.WriteLine("2nd root={0}", x2);
            }
            else
            {

                Console.WriteLine("Given root are Imagenary");
            }

            Console.ReadLine();
        }
    }
}
