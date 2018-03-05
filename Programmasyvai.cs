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
            int[] m = new int[10];
            for (int i=0;i<5;i++)
            {
                Console.Write("iveskite skaiciu");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i= 0; i<m.Length;i++)
            {
                if(m[i]>max)
                {
                    max = m[i];
                }
                else if (m[i]<min)
                {
                    min = m[i];
                }

            }
            Console.WriteLine("maziausia masyvo reiksme yra: " + min);
            Console.WriteLine("didziausia masyvo reiksme yra: " + max);
            Console.ReadKey();
        }
    }
}
