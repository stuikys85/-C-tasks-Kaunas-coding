using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite studento amziu");
            int a = Convert.ToInt32(Console.ReadLine());
            int sk1 = 25;
            int sk2 = 30;
            if (a>sk1)
            {
                Console.WriteLine("studento amzius didesnis nei pirmas skaicius"+sk1);
            }
            else if (a>sk2)
            {
                Console.WriteLine("Studento amzius yra didesnis nei antras skaicius" + sk2);

            }
            else
            {
                Console.WriteLine("Studento amzius nei uz pirma nei uz antra skaiciu nedidesnis");
            }
            Console.ReadKey();
        }
    }
}
