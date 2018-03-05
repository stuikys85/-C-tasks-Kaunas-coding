using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp146
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vardai = {"jonas ", "petras", "Inga", "Gabija" };
            List<string> vardas = new List<string>();
            Random rng = new Random();
            for(int i =0;i<8;i++ )
            {
                vardas.Add(vardai[rng.Next(3)]);
            }
        foreach(string name in vardas)
            {
                Console.Write(name + ", ");
            }
            Console.ReadKey();



        }
    }
}
