using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp130
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kada mokinys pradejo namu darbus VALANDA:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kada mokinys pradejo namu darbus MINUTEs:");
            int min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kada mokinys baige namu darbus VALANDA:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kada mokinys baige namu darbus MINUTEs:");
            int min2 = Convert.ToInt32(Console.ReadLine());
            int sumval = val2 - val1;
            int summin = min2 - min1;
            if (min1 > min2)
            {
                val1--;
                Console.WriteLine("mokinys sprende namu darbus: " +"VAL: " + sumval +" MIN: " + summin);
            }
            else
            {
                Console.WriteLine("mokinys sprende namu darbus: " +"VAL: "+ sumval +" MIN: " + summin);
            }Console.ReadKey();
        }
    }
}
