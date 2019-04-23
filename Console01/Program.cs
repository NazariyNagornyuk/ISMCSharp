using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, a, b, x;
            Console.WriteLine("Input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x");
            x = Convert.ToDouble(Console.ReadLine());

            y = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * Math.Pow((Math.Sin(a - b)), 2) + (Math.Pow(10, -2) * (x - b));

            Console.WriteLine("Output y = " + y);
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
