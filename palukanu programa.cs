using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SEB banko dvieju metu palukanu skaiciuokle");
            Console.WriteLine("Iveskite suma kuria desite i banka 2017");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite banko mokamas palukanas 2017");
            int p1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite suma kuria desite i banka 2018");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite banko mokamas palukanas 2018");
            int p2 = Convert.ToInt32(Console.ReadLine());
            int p17 = s1 / 100 * p1;
            int p18 = s2 / 100 * p2;
            Console.WriteLine("Jusu suma su palukanomis 2017:" + s1+""+p17 + "Jusu suma su palukanomis 2018:" + s2+""+ p18 + "Dvieju metu gauta suma su malukanomis" + s1+""+p17+""+s2+""+p18);
            Console.ReadKey();

            
        }
    }
}
