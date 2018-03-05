using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("programa skaiciuojanti lapus");
            Console.WriteLine("Irasykite mokiniu skaiciu klaseje");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Irasykite kiek lapu sudaro konspektas");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Norint nukopinuoti visai klasei konspekta lapu reikes" + (sk1 * sk2));
            Console.ReadKey();


        }
    }
}
