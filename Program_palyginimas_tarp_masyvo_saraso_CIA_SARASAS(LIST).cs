using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp128
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 1;
            List<int> sarasas = new List<int>();
            while(r <= n)
            {
                sarasas.Add(r);
                r *= 2;
            }
            foreach( int sk in sarasas)
            {
                Console.WriteLine(sk);
            }
            Console.ReadKey();
        }
    }
}
