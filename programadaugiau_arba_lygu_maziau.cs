using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk1 = 10;
            int sk2 = 20;
            int sk3 = 30;


            if (sk1 > sk2 && sk1 < 100)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antra skaiciu ir mazesnis uz 100");
            }
            else if (sk2 > 0 && sk2 > sk1)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz 0 ir uz pirma skaiciu");
            }
            else if (sk1 > sk2 && sk1 > sk3 || sk1 > 0)
            {
                Console.WriteLine("pirmas skaicius yra didesnis uz antra ir didesnisuz 3 ir didesnis nei 0");
            }
            else if (sk3 >=5 && sk3 <=10|| sk3 > sk2)
            {
                Console.WriteLine("trecias skaicius patenka i rezius [5-10](>=ir<=) arba didesnis uz pirma skaiciu, arba didesnis uz antra skaiciu");
            }
            Console.ReadKey();
        }
    }
}
