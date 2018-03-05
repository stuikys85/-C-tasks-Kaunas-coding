using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp148
{
    class Program
    {
        public bool Ar_tvarkingas(int skaicius)
        {
            int sk1 = skaicius % 10;
            skaicius /= 10;
            int sk2 = skaicius % 10;
            if(sk1>=sk2)
                {
                if (skaicius==0)
                {
                    return true;
                }
                else
                {
                   if (Ar_tvarkingas(skaicius))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<10)
            {
                Console.WriteLine("Didziausias tvarkingas skaicius yra " + n);
            }
            else
            {
                Program p = new Program();
                while (!p.Ar_tvarkingas(n)) 
                {
                    n--;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
