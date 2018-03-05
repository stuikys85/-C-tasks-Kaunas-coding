using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    class Program

    {

        public void Paraso_teksta(string vardas, int amzius, string hobis)
        {
            Console.WriteLine("Jusu vardas yra {0}, jums yra {1}, jusu hobis yra {2}", vardas,amzius,hobis);
            Console.ReadKey();
        }
         public static void Pasisveikina()
        {
            Console.WriteLine("sveiki");
        }


        static void Main(string[] args)
        {
            Pasisveikina();
            Program p = new Program();
            Console.WriteLine("Koks jusu vardas");

            string vardas = Console.ReadLine();
            Console.WriteLine("koks jusu amzius");
            int amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("koksjusu hobis");
            string hobis = Console.ReadLine();
        
}     
        }
    }
}
