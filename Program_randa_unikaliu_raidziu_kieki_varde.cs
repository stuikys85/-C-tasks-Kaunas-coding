using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp109
{
    class Program
    {
        public int Unikalios_raides(Char[] raides)
        {
            int unikaliu_r_k = 0;
            for(int i=0; i< raides.Length;i++)
            {
                int flag = 0;
                for(int j=(i+1); j<(raides.Length-1-i);j++)
                {
                    if(raides[i] == raides[j])
                    {
                        flag++;
                    }
                } 
                if(flag==0)
                {
                    unikaliu_r_k++;
                }

            }
            return unikaliu_r_k;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("iveskite visus kandidatus vesti vienoje eiluteje atskiriant tarpu");
            string kandidatai = Console.ReadLine();
            StreamReader reader = new StreamReader();
            string[] vardus = kandidatai.Split(' ').ToArray();
            int unique = 0;
            int prezi_index = -1;
            Program p = new Program();

            for (int i = 0; i < vardus.Length; i++)
            {
                char[] raides = vardus[i].ToCharArray();
                if(unique < p.Unikalios_raides(raides))
                {
                    unique = p.Unikalios_raides(raides);
                    prezi_index = i;
                }
            }
            Console.WriteLine("rinkimus laimejo:" + vardus[prezi_index]);

            Console.ReadKey();
        }
    }
}
