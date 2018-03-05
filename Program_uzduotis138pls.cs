using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek temperaturos reiksmiu bus?");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tempera = new double [n];
            for (int i=0; i<n;i++)
            {
                Console.WriteLine("Iveskite temperaturos REIKSMES");
                tempera[i] = Convert.ToDouble(Console.ReadLine());
            }

            double min = tempera.Min();
            double max = tempera.Max();
            double ave = tempera.Average();
            double sum = 0;
            foreach(double temp in tempera)
            {
                if(temp>ave)
                {
                    sum++ temp;
                }
            }
            Console.WriteLine("didziausia temperatura yra {0}, maziausias - {1}, vidurkis-{2}");
            Console.ReadKey();



        }
    }
}
