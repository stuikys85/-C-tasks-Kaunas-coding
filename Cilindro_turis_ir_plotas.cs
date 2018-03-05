using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa apskaiciuojanti CILINDRO TURI IR CILINDRO PAVIRSIAUS PLOTA");
            Console.WriteLine("Iveskite CILINDRO AUKSTI: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite CILINDRO SPINDULI: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double PI = 3.141592654;
            Double turis = (PI * (r * r)) * h;
            double plotas = 2 * PI * r * (r + h);
            Console.WriteLine("Cilindro turis yra : " + turis + "Cilindro plotas yra: " + plotas);
            Console.ReadKey();
           }
       
        
        
    }
}
