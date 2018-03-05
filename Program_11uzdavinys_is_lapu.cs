using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa seimos biudzetui skaiciuoti");
            Console.WriteLine("Iveskite kiek seima gauna pajamu i menesi: ");
            double pajamos = Convert.ToDouble(Console.ReadLine());
            double pomokesciu = pajamos - (pajamos * 5) / 100;
            double pomaisto = pomokesciu - (pomokesciu * 50) / 100;
            double porubu = pomaisto - (pomaisto * 30) / 100;
            double likpramog = porubu;
            Console.WriteLine("Jus isleidziate mokesciams 5% ir lieka: " + pomokesciu + "Jus isleidziate maistui 50% ir lieka: " + pomaisto + "Jus isleidziate rubams 30% ir lieka: " + porubu + "Suma isleisti pramogoms jums liks: "+likpramog);
            Console.ReadKey();


        }
    }
}
