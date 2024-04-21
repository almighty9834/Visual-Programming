using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" PROBLEM NO 04");
            Console.WriteLine(" \n"); 

             Console.WriteLine(" Ayesha Mukhtar");
            Console.WriteLine(" Roll #14");
            Console.WriteLine(" \n");

            double num;
            Console.Write(" Enter the numbers to convert = ");
            num = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\n Choose type of conversion...");
            Console.WriteLine(" \n");

            Console.WriteLine("  1 = Inches to Cms");
            Console.WriteLine("  2 =  Gallon to Liters");
            Console.WriteLine("  3 = Mile to Kilometers");
            Console.WriteLine("  4 =  Pound to Kilograms");
            Console.WriteLine(" \n");
            Console.Write("Enter your choice (1-4) = ");
            Console.WriteLine(" \n");

            int con = Convert.ToInt32(Console.ReadLine());
            
            switch (con)
            {
                case 1:
                  
                    double ToCenti = num * 2.54;
                    Console.WriteLine(" inches =  cms \n"  +ToCenti);
                    
                    break;

                case 2:
                    
                    double ToLitr = num * 3.785;
                    Console.WriteLine(" gallons = liters \n"+ToLitr);
                    
                    break;

                case 3:
                    
                    double ToKiloms = num * 1.609;
                    Console.WriteLine(" miles = kilometers \n"+ToKiloms);
                    
                    break;

                case 4:
                    
                    double ToKilograms = num * 4536;
                    Console.WriteLine(" pounds =  kilograms \n"+ToKilograms);

                    break;

                default:
                    Console.WriteLine("Invalid choice.\nChoose (1-4).");
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
