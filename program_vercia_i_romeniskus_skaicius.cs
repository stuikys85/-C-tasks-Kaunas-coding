using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program



    {
        public void desimtys(int skaicius)


        {


            if (skaicius == 9)
            {
                Console.Write("IX");
            }
            else if (skaicius == 4)
            {
                Console.Write("IV");
            }
            else
            {
                int v = skaicius / 5;
                if (v == 1)
                {
                    Console.Write("V");
                }
                int ii = skaicius % 5;
                for (int i = 0; i < ii; i++)
                {
                    Console.Write("I");
                }
            }
        }



        public void vienetai(int skaicius)

       
        {
         
        
                if (skaicius == 9)
                {
                    Console.Write("IX");
                }
                else if (skaicius == 4)
                {
                    Console.Write("IV");
                }
                else
                {
                    int v = skaicius / 5;
                    if(v == 1)
                    {
                        Console.Write("V");
                    }
                    int ii = skaicius % 5;
                    for (int i = 0; i<ii;i++)
                    {
                        Console.Write("I");
                    }
                }
            }
            static void Main(string[]args)
            { 
            Console.WriteLine("Iveskite pirma skaiciu nuo 1 iki 1000");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int vnt = skaicius % 10;
            int dsm = (skaicius % 100) / 10;
            int sim = skaicius / 100;
            Console.WriteLine(vnt + " " + dsm + " " + sim);
                Program p = new Program();
                p.vienetai(vnt);
            Console.ReadLine();


        }
    }
}
