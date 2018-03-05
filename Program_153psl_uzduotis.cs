using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp129
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random(10000);
            int d = rng.Next(10000);
            List<int> listas = new List<int>();
            for ( int i=0; i<d;i++)
            {
                listas.Add(rng.Next(10000));
            }
            Console.WriteLine("suma" + listas.Sum());
            Console.WriteLine("Vidurkis" + listas.Average());
            Console.WriteLine("Kiekis" + listas.Count);
            int ums = 0;
            foreach(int sk in listas)
            {
                int liekana = sk % 2;
                if(liekana != 0)
                {
                    ums += sk;
                }
            }
            Console.WriteLine("Visu nelyginiu skaiciu suma yra:" + ums);
            Console.ReadKey();
        }
    }
}
