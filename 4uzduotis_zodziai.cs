﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite megiamiausios spalvos pirma raide");
            char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("Iveskite atsitiktini skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite atsitiktini skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus ivedete varda " + vardas +
                " jusu megiamiausios spalvos pirma raide yra " + raide +
                " ivestas atsitiktinis skaicius " + sk1 +
                " antras ivestas atsitiktinis skaicius" + sk2);
            
            Console.ReadKey();
        }
    }
}
