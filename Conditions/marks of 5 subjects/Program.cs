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
            Console.WriteLine("PROBLAM 2");
            Console.WriteLine("\n");
            Console.WriteLine("Ayesha Mukhtar");
            Console.WriteLine("Roll #14");
            Console.WriteLine("\n");


            int sub1, sub2, sub3, sub4, sub5;

            Console.Write("Enter your mark in 1st subject=\t");
            sub1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter your mark in 2nd subject=\t");
            sub2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter your mark in 3rd subject=\t");
            sub3 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter your mark in 4th subject=\t");
            sub4 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter your mark in 5th subject=\t");
            sub5 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Find Percentange");


            float per;
            per = (sub1 + sub2 + sub3 + sub4 + sub5) * 100 / 500;
            Console.WriteLine("percentage is equal to="+per);

            if(per>=80)
            {
                Console.WriteLine("Grade A");
            }

            else if(per>=65)
            { 
                Console.WriteLine("Grade B");
            }

            else if(per>=50)
            {
                Console.WriteLine("Grade c");
            }

            else if(per>=40)
            {
                Console.WriteLine("Grade D");
            }

            else
            {
                Console.WriteLine("Grade F");
            }
                
               

            Console.ReadLine();
        }
    }
}
