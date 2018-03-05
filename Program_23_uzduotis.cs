using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite metus tarp 1986 ir 2020.\n jums bus pasakyta kurie yra OLIMPINIAI METAI O KURIE NE");
            int metai = Convert.ToInt32(Console.ReadLine());

            for (int i=metai;i<2020;i++ )
            {
                if (i%2==0 )
                {
                    Console.WriteLine("metai yra olimpiniai "+i);
                    break;
                }
                else
                {
                    Console.WriteLine("metai nera olimpiniai"+i);
                    break;
                }
            }
            Console.ReadKey();


        }
    }
}
