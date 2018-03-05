using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 1; i < 100; i++) 
            {
                int liekana = i % 7;
                if (liekana ==0)
                {
                    sandauga *= i;
                }
            } Console.WriteLine("sandauga:" + sandauga);
            Console.ReadKey();
        }
    }
}
