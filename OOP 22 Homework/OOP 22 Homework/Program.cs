using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_22_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp rock = new Camp(243.2, 24.5, 56, 20, 10);
            Camp star = new Camp(226.2, 23.4, 53, 27, 15);

            if(rock > star)
            {
                Console.WriteLine("Camp Rock!");
            }
            else
            {
                Console.WriteLine("Camp Star!");
            }

            Camp rockStar = rock + star;

            Console.WriteLine(rock);
            Console.WriteLine();
            Console.WriteLine(star);
            Console.WriteLine();
            Console.WriteLine(rockStar);
        }
    }
}
