using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek laikrodis rodo valandu h:");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek laikrodis rodo minuciu m:");
            int min = Convert.ToInt32(Console.ReadLine());
            int suma1 = val * 60 + min;
            int suma2 = suma1 * 60;
            Console.WriteLine("Jus ivedete: " + val + " " + min + "ir tai yra Minuciu " + suma1 + "ir tai yra Sekundziu: " + suma2);
            Console.ReadKey();

        }
    }
}
