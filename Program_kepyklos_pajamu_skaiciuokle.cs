using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kepyklos pajamu skaiciuokle");
            Console.WriteLine("Iveskite kiek darbuotojas gali iskepti duonos kepalu per valanda:");
                int d1val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek darbuotoju dirba kepykloje:");
                int d1kep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite Vieno kepalo savikaina:");
                int kep1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite Vieno kepalo pardavimo kaina:");
            int kep1sav = Convert.ToInt32(Console.ReadLine());

            int perdiena = (d1kep * d1val)*8;
            int viskepsav = perdiena * kep1;
            int gautospajam = viskepsav * kep1sav;
            int gautaspelnasdal = gautospajam - viskepsav;

            Console.WriteLine("Per diena kepykla iskeps:" + perdiena);
            Console.WriteLine("Visu kepalu iskeptu per diena savikaina:" + viskepsav);
            Console.WriteLine("Gautos pajamos pardavus:" + gautospajam);
            Console.WriteLine("Gauto pelno dalis yra" + gautaspelnasdal);
            Console.ReadKey();



        }
    }
}
