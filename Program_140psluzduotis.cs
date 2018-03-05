using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 1;
            int kiekis = 0;
            while(r<=n)
            {
                kiekis++;
                r *= 2;
            }
            r = 1;
            int[] masyvas = new int[kiekis];
            for(int i=0; i < kiekis; i++)
            {
                masyvas[i] = r;
                r *= 2;
            }
            foreach(int sk in masyvas)
            {
                Console.WriteLine(sk);
                Console.ReadKey();
            }
        }
    }
}
