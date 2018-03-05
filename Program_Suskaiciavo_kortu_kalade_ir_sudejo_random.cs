using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp151
{
    class Korta
    {
        public string simbolis { get; }
        public int reiksme { get; }
        public char sim_rai;
        public string reik_trum;

        private void Simol_raid_con ()
        {
            switch(simbolis)
            {
                case "Bugnai":
                    sim_rai = 'B';
                    break;
                case "Kryziai":
                    sim_rai = 'K';
                    break;
                case "Sirdys":
                    sim_rai = 'S';
                    break;
                case "Vynai":
                    sim_rai = 'V';
                    break;
            }
        }
        private void Reiks_con()
        {
            switch(reiksme)
            {

            case 2:
            reik_trum = "2";
            break;
            case 3:
            reik_trum = "3";
            break;
            case 4:
            reik_trum = "4";
             break;
            case 5:
            reik_trum = "5";
            break;
            case 6:
            reik_trum = "6";
            break;
            case 7:
            reik_trum = "7";
            break;
            case 8:
            reik_trum = "8";
            break;
            case 9:
            reik_trum = "9";
            break;
            case 10:
            reik_trum = "10";
            break;
            case 11:
            reik_trum = "J";
            break;
            case 12:
            reik_trum = "Q";
            break;
            case 13:
            reik_trum = "K";
            break;
            case 1:
            reik_trum = "A";
            break;


            }
        }


        public Korta(string Simb, int reiks)
        {
            simbolis = Simb;
            reiksme = reiks;
            Simol_raid_con ();
            Reiks_con ();
            

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Korta> kalde = new List<Korta>();
            string[] simboliukai = { "Bugnai", "Sirdys", "Kryziai", "Vynai" };
            Random rng = new Random();

            int i = 0;
            while(i<52)
            {

                Korta kort = new Korta(simboliukai[rng.Next(0,4)], rng.Next(1, 14));
                int flag = 0;
                
                foreach(Korta kor in kalde)
                {
                    if(kor.simbolis == kort.simbolis && kor.reiksme == kort.reiksme)
                    {
                        flag++;
                    }
                    
                }
                if (flag ==0)
                {
                    i++;
                    kalde.Add(kort);
                }
            }
            foreach(Korta kor in kalde)
            {
                Console.Write(kor.sim_rai);
                Console.Write(" "+kor.reik_trum);
                Console.WriteLine();
            }
            Console.WriteLine(kalde.Count);
            Console.ReadKey();
        }
    }
}
