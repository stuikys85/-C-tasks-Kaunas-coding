using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite visa traukinio keleiviu skaiciu");
            int visasskaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite Keleiviu skaiciu vykstanti ne i Vilniu");
            int nevilnius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite traukinio vagonu skaiciu");
            int vagskaicius = Convert.ToInt32(Console.ReadLine());
            int suma = (visasskaicius - nevilnius) / vagskaicius;
            Console.WriteLine("Keleiviu vykstanciu i Vilniu VIENAM VAGONE YRA :" + suma);
            Console.ReadKey();
        }
    }
}
