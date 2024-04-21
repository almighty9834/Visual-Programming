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
            Console.WriteLine("TOTAL MARKS OF DIFFERENT SUBJECTS:" );
            double number1, number2, number3, number4, number5;
            Console.WriteLine("\n");

            Console.Write("Enter mark in Visual Programming:");
            number1 = Convert.ToDouble(Console.ReadLine() );


            Console.Write("Enter marks in Cloud Computing:");
            number2 = Convert.ToDouble(Console.ReadLine() );


            Console.Write("Enter marks in Numerical Analysis:");
            number3 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter marks in Entrepreneurship:");
            number4 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter marks in Informational Securit:");
            number5 = Convert.ToDouble(Console.ReadLine());


            double sum = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine("\n");
            Console.WriteLine("Sum of marks= "+sum);

            double avg = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.WriteLine("\n");
            Console.WriteLine("Average of marks= "+avg);

            Console.ReadLine();

        }
    }
}
