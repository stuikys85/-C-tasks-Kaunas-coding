using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite treciaji skaiciu:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            int suma = sk1 + sk2 + sk3;
            int sandauga = sk1 * sk3;
            int sandauga1 = sk2 * sk3;
            switch (sk1)
            {
                case 1:
                    Console.WriteLine("Visu skaiciu suma ="+suma);
                    break;
                case 2:
                    Console.WriteLine("Pirmo ir trecio skaiciaus sandauga yra =" + sandauga);
                    break;
                case 3:
                    Console.WriteLine("Antrojo ir treciojo sandauga yra =" + sandauga1);
                    break;
            }
            Console.ReadKey();
        }
    }
}
