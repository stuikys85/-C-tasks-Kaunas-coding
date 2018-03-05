using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite maziausio skritulio spinduli: ");
            double r =Convert.ToDouble(Console.ReadLine());
            double s1 = Math.Pow(r, 2) * Math.PI;
            double s2 = Math.Pow(r, 4) * Math.PI;
            double s3 = Math.Pow(r, 6) * Math.PI;
            Console.WriteLine("Pirmojo skritulio plotas yra: \n" + s1 + "\n Antrojo skritulio plotas yra:\n " + s2 + "\n Treciojo skritulio plotas yra:\n" + s3);
            Console.ReadKey();
        }
    }
}
