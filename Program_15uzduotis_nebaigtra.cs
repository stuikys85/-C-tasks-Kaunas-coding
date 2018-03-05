using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testukas kaip, padides pinigines turinys jei Idesite 1 PENSA");
            Console.WriteLine("Iveskite kiek turite SVARU :");
            int svar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek turite SILINGU :");
            int shil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek turite PENSU");
            int pens = Convert.ToInt32(Console.ReadLine());
            if (pens<12)
            {
                pens++;
                Console.WriteLine(" jus turite: " + svar + " SVARU " + shil + " SILINGU " + pens + " PENSU ");
            }
            else if ( pens>12)
            {

            }
            Console.ReadKey();
        }
    }
}
