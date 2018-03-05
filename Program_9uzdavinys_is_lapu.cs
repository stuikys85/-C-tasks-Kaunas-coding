using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite valandas: ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite minutes: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite sekundes:");
            int sec = Convert.ToInt32(Console.ReadLine());
            int sum = sec + 1;
            Console.WriteLine("laikrodis po sekundes rodys: "+val+":"+sec+":"+sum);
            Console.ReadKey();
        }
    }
}
