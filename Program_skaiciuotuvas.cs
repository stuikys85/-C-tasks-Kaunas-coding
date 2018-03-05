using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("basic skaiciavimo masinele");
            Console.WriteLine("Iveskite Pirma skaiciu");
            Double sk1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite Antra skaiciu");
            Double sk2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite Norima veiksma + - * /");
            char zenklas = Convert.ToChar(Console.ReadLine());
            double plius = sk1 + sk2;
            double minus = sk1 - sk2;
            double daugyba = sk1 * sk2;
            double dalyba = sk1 / sk2;
            if (zenklas =='+')
            {
                Console.WriteLine("Suma sudejus bus:"+zenklas +"="+ plius);
            }
            if (zenklas =='-')
            {
                Console.WriteLine("Suma atemus bus:" + zenklas + "=" + minus);
            }
            if (zenklas== '*')
            {
                Console.WriteLine("Suma sudauginus bus:" + zenklas + "=" + daugyba);
            }
            if (zenklas == '/')
            {
                Console.WriteLine("Suma padalinus bus:" + zenklas + "=" + dalyba);
                    }
            Console.ReadKey();
        }
    }
}
