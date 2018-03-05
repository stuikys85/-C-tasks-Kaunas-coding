using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skyscio kieki GALONAIS:");
            int galon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skyscio kieki BUSELIAIS:");
            int busel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus Ivedete: " + galon + "GALONUS" + "IR" + busel + "BUSELIUS");
            double sum1 = galon * 4.54069;
            double sum2 = (busel * 8) * 4.54069;
            double atslitrais = sum1 + sum2;
            Console.WriteLine("Susumavus galonus su buseliais suma LITRAIS BUS: "+ atslitrais);
            Console.ReadKey();
        }
    }
}
