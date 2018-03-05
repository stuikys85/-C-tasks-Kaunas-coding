using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite mokiniu kieki:");
            int mokiniai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek konspektas turi lapu:");
            int lapai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("reikia lapu=" + (mokiniai * lapai));
            Console.ReadKey();
        }
    }
}
