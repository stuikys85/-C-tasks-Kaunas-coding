using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antraji skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if (sk1>sk2)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antra");
  
            }
            if (sk1<sk2)
            {
                Console.WriteLine("Pirmas skaicius yra mazesnis uz antra");
            }
            if (sk1==sk2)
            {
                Console.WriteLine("abu skaiciai yra lygus");
            }
            Console.ReadKey();
        }
    }
}
