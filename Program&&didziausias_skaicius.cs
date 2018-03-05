using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("iveskite pirma skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite trecia skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            if (sk1>sk2&&sk1>sk3)
            {
                Console.WriteLine("Pirmas skaicius yra didziausias"+sk1);
            }
            else if (sk2>sk1&&sk2>sk3)
            {
                Console.WriteLine("antras skaicius diziausias" + sk2);
            }
            else if (sk3>sk2&&sk3>sk1)
            {
                Console.WriteLine("trecias skaicius yra didziausias" + sk3);
            }
            Console.ReadKey();
        }
    }
}
