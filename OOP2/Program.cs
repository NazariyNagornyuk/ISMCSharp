using System;
using System.Collections.Generic;
using System.Text;
using OOPLib2;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] array = new Human[5];
            array[0] = new Human("Ivan", "Ivanov", 13, 11, 1984);
            array[1] = new Abitur("Mutant", "Mutantov", 26, 04, 1986, 200, 200, 200, 12.99, "Chernobyl School Number 13");
            array[2] = new Student("Veronika", "Golovatenko", 10, 07, 2002, 2, "D-28", "Design", "MOD");
            array[3] = new Teacher("Mykola", "Maksimenko", 01, 02, 1940, "oldfag", "Schemotechnics", "MOD");
            array[4] = new Reader("Sidor", "Sidorovich", 24, 08, 1991, 1488, 28, 06, 1996, 4173);

            for (int i=0; i<array.Length; i++)
            {
                array[i].ShowInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
