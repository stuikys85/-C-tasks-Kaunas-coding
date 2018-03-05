using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite masyvo ilgi");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            for (int i = 0;i<m.Length;i++)
            {
                Console.Write("iveskite skaiciu");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxx = m.Max();
            int kiekis = 0;
            for (int i=0;i<m.Length;i++)
            {
                if(m[i]==maxx)
                {
                    kiekis++;
                }
            }
            int max = int.MinValue;
            Console.WriteLine("didziausias spinduliu kiekis" + max);
            Console.WriteLine("spinduliu kiekis " + kiekis);
            Console.ReadKey();
        }

    }
}
