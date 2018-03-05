using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skritulio ploto skaiciuokle");
            Console.WriteLine("iveskite pirmojo skritulio spinduli");
            double r = Convert.ToDouble(Console.ReadLine());
            double s1 = Math.Pow(r, 2) * Math.PI;
            double s2 = Math.Pow(r, 4) * Math.PI;
            double s3 = Math.Pow(r, 6) * Math.PI;
            Console.WriteLine("Pirmojo skritulio plotas yra {0}, Antrojo skritulio plotas yra {1}, Treciojo skritulio plotas yra {2}", s1, s2, s3);
            Console.ReadKey();
        }
    }
}
