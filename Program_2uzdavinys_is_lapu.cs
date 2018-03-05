using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kambario ilgi:");
            int ilgis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite kambario ploti:");
            int plotis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ivskite plyteles kvadratinio metro kaina:");
            int kaina = Convert.ToInt32(Console.ReadLine());
            int suma = (ilgis * plotis) * kaina + (ilgis * plotis) * 5 / 100;
            Console.WriteLine("Kambari iskloti plytelemis reikes:" + suma);
            Console.ReadKey();

        }
    }
}
