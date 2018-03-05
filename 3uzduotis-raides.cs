using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zodi arba sakini");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Jusu ivestas tekstas =" + tekstas);
            Console.ReadKey();
        }
    }
}
