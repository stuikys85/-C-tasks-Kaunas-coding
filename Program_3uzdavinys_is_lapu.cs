using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek Pinigu padesite i banka 2017");
            int pinigai1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek Bankas moka palukanu 2017");
            int paluk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek Pinigu padesite i banka 2018");
            int pinigai2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek Bankas moka palukanu 2018");
            int paluk2 = Convert.ToInt32(Console.ReadLine());
            int suma = pinigai1 + (pinigai1 * paluk1 / 100);
            int suma1 = pinigai2 + (pinigai2 * paluk2 / 100);
            int vissuma = suma + suma1;
            Console.WriteLine("Jusu suma 2017 metais su procentais bus: " + suma + "Jusu suma 2018 su procentais bus: " + suma1 + "Abieju metu suma su procentais bus: " + suma + suma1);
            Console.ReadKey();
            

        }
    }
}
