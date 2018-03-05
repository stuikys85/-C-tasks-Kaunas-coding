using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite Virsutinio kairiojo tasko pirma kordinate X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite Virsutinio kairiojo tasko antra kordinate Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite Apatinio desniojo tasko pirma kordinate X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite Apatiniojo desniojo tasko pirma kordinate Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int S = y1 * x2;
            int P = (y1 * 2) + (x2 * 2);
            if(x2>x1&&y1>y2)
            {
                Console.WriteLine("Staciakampio PLOTAS yra: " + S + "\n Staciakampio PERIMETRAS yra : " + P);
            }
            else
            {
                Console.WriteLine("Salyga negalima nes, X2<X1 ir Y1<Y2, ");
            }
            Console.ReadKey();
        }
    }
}
