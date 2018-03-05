using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa ar gausis trikampis");
            Console.WriteLine("Iveskite pirma krastines ilgi");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra krastines ilgi");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecios krastines ilgi");
            int c = Convert.ToInt32(Console.ReadLine());
            int ac = a + c;
            int ab = a + b;
            int cb = c + b;


            if (ac > b)
            {
                Console.WriteLine("Trikampis imanomas");
            }
            else
            {
                Console.WriteLine("Trikampis neimanomas");
            }
            if (ab > c)
            {
                Console.WriteLine("trikampis imanomas");
            }
            else
            {
                Console.WriteLine("Trikampis neimanomas");
            }
            if (cb > a)
            {
                Console.WriteLine("trikampis imanomas");
            }
            else
            {
                Console.WriteLine("Trikampis neimanomas");
            }
            Console.ReadKey();



        }
    }
}
