using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite VALANDA kada studentas pradejo sprest kontrolini:");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite MINUTES kada studentas pradejo sprest kontrolini:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite SECUNDES kada studentas pradejo sprest kontrolini:");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite VALANDA kada studentas baige sprest kontrolini:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskiyte MINUTES kada studentas baige sprest kontrolini:");
            int min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskiyte SECUNDES kada studentas baige sprest kontrolini:");
            int sec1 = Convert.ToInt32(Console.ReadLine());
            int minats = min1 + 60;
            int secats = sec2n + 60;
            int sum1 = val1 - val;
            int sum2 = min1 - min;
            int sum3 = sec1 - sec;

            if (min1<min)
            {
                val--;
                minats;
                
                
                Console.WriteLine("Studentas atliko darba per :" + sum1 + " Valandu " + sum2 + " MINUCIU " + sum3 + " SEKUNDZIU. ");
            }
            else if (sec1<sec)
            {
                min--;
                secats;

                Console.WriteLine("Studentas atliko darba per :" + sum1 + " Valandu " + sum2 + " MINUCIU " + sum3 + " SEKUNDZIU. ");

            }
            Console.ReadKey();
        }
    }
}
