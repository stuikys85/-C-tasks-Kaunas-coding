using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 2;
            for (int i = 3; i < 1000; i++)
            {
                int flag = 0; //jei skaicius pirminis flag=0
                for (int j = 2; j < i; j++)//imamas intervalas nuo 2 iki tikrinamo skaiciaus (2;n)
                {
                    int liekana = i % j;
                    if (liekana == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
