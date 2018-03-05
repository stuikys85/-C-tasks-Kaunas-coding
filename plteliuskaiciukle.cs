using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plyteliu skaiciuokle");
            Console.WriteLine("Iveskite kambario ilgi:");
            int ilgis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kambario ploti:");
            int plotis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite plyteliu kvadratinio metro kaina:");
            int kaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite kiek % plyteliu pirksite daugiau:");
            int procentai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uz kambario grindims skirtas plyteles jus reiks sumoketi:" + (ilgis * plotis) * kaina + ((ilgis * plotis) * kaina)*5/100);
            Console.ReadKey();
        }
    }
}
