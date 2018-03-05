using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite mokiniu skaiciu");
            int mokskaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek lapu sudaro konspekta");
            int kiek = Convert.ToInt32(Console.ReadLine());
            int suma = mokskaicius * kiek;
            Console.WriteLine("Nukopijuoti konspekta visos klases mokiniams reikes" + suma);
            Console.ReadKey();
        }
    }
}
