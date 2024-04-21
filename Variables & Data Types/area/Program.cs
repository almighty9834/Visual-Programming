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
            Console.Write("  \n");
             int lenght;
            Console.Write("Enter the lenght of rectangle\t= ");
            lenght = Convert.ToInt32(Console.ReadLine());

            int width;
            Console.Write("Enter the width of rectangle\t= ");
            width = Convert.ToInt32(Console.ReadLine());

            int area;
            area = lenght * width;
            Console.WriteLine("\tArea of rectangle\t=" + area);

            int per;
            per = 2*(lenght + width);
            Console.WriteLine("\tPerimeter of rectangle\t=" + per);


            Console.ReadLine();
        }
    }
}
