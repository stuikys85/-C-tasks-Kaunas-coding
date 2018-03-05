using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pasirinkta skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (sk1>=0)
            {
                Console.WriteLine(sk1);
                
                int liekana = sk1 % 2;
                if (liekana==0)
                  
                {
                    sum += sk1;
                    Console.WriteLine(sum);
                }Console.ReadKey();
                

            }
        }
    }
}
