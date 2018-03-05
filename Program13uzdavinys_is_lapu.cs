using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmos lazdeles ilgi Coliais:");
            double l1ilg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antros lazdeles ilgi Coliais:");
            double l2ilg = Convert.ToDouble(Console.ReadLine());
            double peda = 12;
            double jardas =3;
            double sum1col = l1ilg + l2ilg;
            double sum2ped = sum1col / peda;
            double sum3jard = sum2ped / jardas;
            Console.WriteLine("Jusu ivestas abieju lazdeliu sumos ilgis COLIAIS bus:" + sum1col + "Pedomis bus: " + sum2ped + "Jardais bus: " + sum3jard);
            Console.ReadKey();

        }
    }
}
