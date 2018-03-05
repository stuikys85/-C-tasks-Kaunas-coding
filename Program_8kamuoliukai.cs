using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            onsole.WriteLine("Turim 8 kamuoliukus vienas defektuotas tikrinsim kuris");
            int k1 = 5;
            int k2 = 5;
            int k3 = 5;
            int k4 = 4;
            int k5 = 5;
            int k6 = 5;
            int k7 = 5;
            int k8 = 5;

            if (k1 + k2 + k3 == k4 + k5 + k6)
            {
                Console.WriteLine("k1 k2 k3 = k4 k5 k6 lygus svoris, tai defektuotas kamuoliukas yra k7 arba k8");
            }
            else if (k1 + k2 + k3 > k4 + k5 + k6)
            {
                Console.WriteLine("Defektuotas kamuoliukas yra tarp k4 k5 k6");
            }
            else if (k1 + k2 + k3 < k4 + k5 + k6)
            {
                Console.WriteLine("defektuotas kamuoliukas tarp k1 k2 k3");
            }
            else if (k7 > k8)
            {
                Console.WriteLine("defektuotas kamuoliukas yra k8");
            }
            else
            {
                Console.WriteLine("defektuotas kamuoliukas yra k7");
            }
            if (k4 == k5 )
            {
                Console.WriteLine("kamuoliukas 6 yra defektuotas");
            }
            else if (k4>k5)
            {
                Console.WriteLine("k5 defektuotas kamuoliukas");
            }
            else if (k4<k5)
            {
                Console.WriteLine("kamuoliukas k4 defektuotas");
            }
            else if (k1 == k2)
            {
                Console.WriteLine("defektuotas kamuoliukas k3");

            }
            else if (k1<k2)
            {
                Console.WriteLine("defektuotas yra k1 kamuoliukas");

            }
            else
            {
                Console.WriteLine("defektuotas kamuoliukas yra k2");
            }
            Console.ReadKey();



        }
    }
}
