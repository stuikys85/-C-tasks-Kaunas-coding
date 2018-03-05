using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 14;
            var b = 32;
            var c = a + b;
            var D = a - b;
            var e = a * b;
            var f = (double)a / b;
            Console.WriteLine(a + "+" + b + "="+ c );
            Console.WriteLine(a + "+" + b + "=" + D);
            Console.WriteLine(a + "+" + b + "=" + e);
            Console.WriteLine(a + "+" + b + "=" + f);
            Console.ReadKey();
        }
    }
}
