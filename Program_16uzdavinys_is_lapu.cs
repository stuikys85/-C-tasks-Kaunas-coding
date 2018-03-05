using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivedus PARU skaiciu,\n programa paskaicius kiek yra VALANDU, MINUCIU, SEKUNDZIU \n ivestose PAROSE:");
            Console.WriteLine("Iveskite PARU skaiciu:");
            int paros = Convert.ToInt32(Console.ReadLine());
            int sumval = paros * 24;
            double summin = (paros * 24) * 60;
            double sumsek = ((paros * 24) * 60) * 60;
            Console.WriteLine("Jusu ivestu PARU skaicius yra : " + paros + "\n Tai yra Valandu: " + sumval + "\n Tai yra Minuciu: " + summin + "\n Tai yra sekundziu: " + sumsek);
            Console.ReadKey();
        }
    }
}
