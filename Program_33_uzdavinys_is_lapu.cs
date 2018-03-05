using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp155
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek pinigu kainuoja *1* cigarete: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kiek per *diena* jaunuolis suruko cigareciu:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek surukytu cigareciu dienos norma uzauga po metu: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double suma = a * b * 365;
            

            for(int i=0;i<c;i++)
            {
                suma += a * b + 365;
                b += c;
            }
            Console.WriteLine(suma);
            Console.ReadKey();


        }
    }
}
