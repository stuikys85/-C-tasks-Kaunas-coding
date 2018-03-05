using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sios dienos jusu pasirinkimas gali buti:");
            Console.WriteLine("1-limonadas.\n 2-arbata.\n 3-kakava. \n 4-kava. \n 5-nieko.");
            Console.WriteLine("Pasirinkite viena is punktu:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote kakava");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 5:
                    Console.WriteLine("jus nieko nepasirinkote");
                    break;
                default:
                    Console.WriteLine("blogai ivestas punktas");
                    break;
            }
            Console.ReadKey();

        }
    }
}
