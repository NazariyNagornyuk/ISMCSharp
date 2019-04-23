using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleQuadEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, c, d, x1, x2, x;
            
            Console.WriteLine("Input A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input C");
            c = Convert.ToDouble(Console.ReadLine());

            d = (Math.Pow(b, 2)) - (4 * a * c);
            if(d<0)
            {
                Console.WriteLine("There are no solutions!");
            }
            else if (d==0)
            {
                x = (-b) / (2 * a);
                Console.Write("X = "+x);
            }
            else if(d>0)
            {
                x1 = (-b + (Math.Sqrt(d))) / (2 * a);
                x2 = (-b - (Math.Sqrt(d))) / (2 * a);
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
