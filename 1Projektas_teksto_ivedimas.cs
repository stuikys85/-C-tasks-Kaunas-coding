using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)

        {
            String Vardas = "Mindaugas";
            String Pavarde = "Stuika";
            int amzius =  32;
            double ugis = 189;
            String aukstoji_mokykla = "kauno_technikos_kolegija";
            char akademines_grupes_kodas= 'f';
            int kursas = 3;
            string studiju_programos_pavadinimas = "itprogramavimas";
            int atsiskaitytu_kreditu_skaicius= 10;

            Console.WriteLine("Vardas" + Vardas);
            Console.WriteLine("Pavarde" + Pavarde);
            Console.WriteLine("amzius" + amzius);
            Console.WriteLine("ugis" + ugis);
            Console.WriteLine("aukstoji_mokykla" + aukstoji_mokykla);
            Console.WriteLine("akademines_grupes_kodas" + akademines_grupes_kodas);
            Console.WriteLine("kursas" + kursas);
            Console.WriteLine("studiju_programos_pavadinimas" + studiju_programos_pavadinimas);
            Console.WriteLine("atsiskaitytu_kreditu_skaicius" + atsiskaitytu_kreditu_skaicius);
            Console.ReadKey();

        }
    }
}
