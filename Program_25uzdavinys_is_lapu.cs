using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite lazdeles ilgi A :");
            int a1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite lazdeles ilgi B :");
            int b1 = Convert.ToInt32(Console.ReadLine());
            
            if (a1==b1)
            {
                Console.WriteLine("Jus galite sudeti KETURKAMPI,visos krastines lygios jus gaunate KVADRATA");
            }
            else if (a1<b1)
            {
                Console.WriteLine("Jus galite sudeti KETURKAMPI, krastines A<B gaunasi staciakampis");

            }
            else if (a1>b1)
            {
                Console.WriteLine("Jus galite sudeti KETURKAMPI, krastines A>B gaunasi staciakampis");
            }
            else if (a1==0)
            {
                Console.WriteLine("Jus negalite sudeti kvadrato");
            }Console.ReadKey();

        }
    }
}
