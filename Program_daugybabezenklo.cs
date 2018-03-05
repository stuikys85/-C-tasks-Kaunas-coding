using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirmaji skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int sandauga = 0;
             for (int i = 0;i<sk1;i++)
            {
                sandauga += sk2;
            }
            Console.WriteLine(sandauga);
            Console.ReadKey();





        }
    }
}
