using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sugalvokite skaicu nuo 0 iki 1000");
            int skaicius1 = 0;
            int skaicius2 = 1000;
            int spejimas = (skaicius1 + skaicius2)/2;
            Console.WriteLine("paspauskite bet kuri mygtuka kad pradeti");
            Console.ReadKey();
            string rezultatas = null;
            while (rezultatas !="atspejai"&&rezultatas != "atspejai" )
            {
                Console.WriteLine("ar tai yra skaicius:" + spejimas);
                Console.WriteLine("jei atspejau , parasyti 'atspejau', jei spejamas skaicius yra mazesnis uz sugalvota rasyti 'maziau', jei didesnis 'daugiau' ");
                rezultatas = Console.ReadLine();
                if (rezultatas == "daugiau")
                {
                    skaicius1 = spejimas;
                    spejimas = (skaicius1 + skaicius2) / 2;
                }
                else if (rezultatas == "maziau")
                {
                    skaicius2 = spejimas;
                    spejimas = (skaicius1 + skaicius2) / 2;
                }
            }
            Console.WriteLine("atspejau" + spejimas);
            Console.ReadKey();
        }
    }
}
