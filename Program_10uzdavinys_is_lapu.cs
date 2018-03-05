using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Programa apskaicius ar katino galva pralys pro duru skyle");
            Console.WriteLine("Iveskite koks yra katino galvos spindulys-r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite duru skyles krastines ilgi: ");
            double krastilg = Convert.ToDouble(Console.ReadLine());
            double katesS = Math.Pow(r, 2) * Math.PI;
            double duruS = krastilg * 2;
            if(katesS<duruS)
            {
                Console.WriteLine("Katinas PRALYS pro duris");
            }
            else
            {
                Console.WriteLine("katinas NEPRALYS pro duris");
            }
            Console.ReadKey();
        }   
    }
}
