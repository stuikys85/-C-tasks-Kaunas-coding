using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite kiek vidutiniskai mokyklos bibliotekoje perskaito knygu per menesi: ");
            int knygosmen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Irasykite kiek per metus apsilanko zmoniu mokyklos bibliotekoje: ");
            int zmonmet = Convert.ToInt32(Console.ReadLine());
            double sum1 = knygosmen * 12;
            double sum2 = sum1 / zmonmet;
            double sum3 = sum2 / 12;
            Console.WriteLine("Vienas mokyklos bibliotekos lankytojas perskaito per menesi knygu: "+sum3);
            Console.ReadKey();

        }
    }
}
