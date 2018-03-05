using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp147
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i=-5; i<=5; i++)
            {
                double y = Math.Sqrt(i * i + 3 * i + 5);
                Console.Write(y + " ");

            }
            Console.ReadKey();
        }
    }
}
