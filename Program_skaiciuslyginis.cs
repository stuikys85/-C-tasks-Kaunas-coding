using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            if (sk % 2 == 0)
            {
                Console.WriteLine("skaicius yra lyginis");
            }
            Console.ReadKey();

        }
    }
}
