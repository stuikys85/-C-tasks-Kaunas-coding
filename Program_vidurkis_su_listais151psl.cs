using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            pazymiai.Add(5);
            pazymiai.Add(10);
            pazymiai.Add(20);
            pazymiai.Add(50);
            pazymiai.Add(40);
            pazymiai.Add(11);
            pazymiai.Add(23);
            pazymiai.Add(55);

            Console.WriteLine("Didziausias pazimys:" + pazymiai.Max());
            Console.WriteLine("Maziausias pazimys:" + pazymiai.Min());
            Console.WriteLine("Vidurkis pazimys:" + pazymiai.Average());
            Console.WriteLine("Pirmas pazimys:" + pazymiai.First());
            Console.WriteLine("Paskutinis pazimys:" + pazymiai.Last());
            Console.ReadKey();
        }
    }
}
