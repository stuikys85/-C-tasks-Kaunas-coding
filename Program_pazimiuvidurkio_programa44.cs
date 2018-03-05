using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int kiekis = 0;
            int pazimys = 0;
            do
            {
                Console.WriteLine("iveskite pazimi, jei ne iveskite 0");
                pazimys = Convert.ToInt32(Console.ReadLine());
                if(pazimys != 0)
                {
                    suma += pazimys;
                    kiekis++;
                }
            } while (pazimys != 0);
            double vidurkis = (double)suma / kiekis;
            Console.WriteLine("vidurkis yra" + vidurkis);
            Console.ReadKey();
        }
    }
}
