using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {

            var skaicius1 = 1;
            var skaicius2 = 1;
            var skaicius3 = skaicius1 + skaicius2;
            Console.WriteLine("Iveskite kiek fibonaciaus skaiciu isvesti");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skaicius1 + " ");
            Console.WriteLine(skaicius2 + " ");
            // ciklas
            for (int i = 2; i < kiek; i++)
            {
                Console.WriteLine(skaicius3 + " ");
                skaicius1 = skaicius2;
                skaicius2 = skaicius3;
                skaicius3 = skaicius1 + skaicius2;
            }
            Console.ReadKey();
        }
    }
}
