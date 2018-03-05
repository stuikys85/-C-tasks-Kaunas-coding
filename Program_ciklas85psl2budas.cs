using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i =0; i<20; i=i+3)
            {
                int liekana = i % 3;
                if(liekana == 0)
                {
                    Console.WriteLine(i);
                        }
            }Console.ReadKey();

        }
    }
}
