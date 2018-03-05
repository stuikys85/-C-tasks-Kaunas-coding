using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp159
{
    class Trasportas
    {
        public bool ratai;
        public int gamybos_metai;
        public string spalva;

        public virtual int uzdarbis(int keleiviu_skaicius, int kaina)
        {
            return keleiviu_skaicius * kaina;
        }
        public void nusidevejimas (int dabartiniai_metai)
        {

        }

        public Trasportas(bool Ratai, int Gamybos_metai, string Spalva)
        {
            ratai = Ratai;
            gamybos_metai = Gamybos_metai;
            spalva = Spalva;
        }
    }

    class Automobilis:Trasportas
    {
        public int duru_sk;
        public int darbinis_turis;
        public string Kebulo_tipas;

        public override int uzdarbis(int keleiviu_skaicius, int kaina)
        {
            return base.uzdarbis(keleiviu_skaicius, kaina);
            {
                Console.WriteLine(base.uzdarbis(keleiviu_skaicius, kaina));
            }
        }

        public void kiek_nuvaziavo_per_metus()
        {

        }
        public Automobilis(int Durusk, int Darbinis_turis, string Kebulo_tipas,bool ratai, int gamybosmetai, string spalva):base(ratai, gamybosmetai, spalva)
        {

        }
    }

    class Laivai : Trasportas
    {
        public int ilgis;
        public string spalva;
        public int aukstis;

        public Laivai(int Ilgis, string Spalva, int Aukstis, bool ratai, int gamybosmetai) : base(ratai, gamybosmetai, Spalva)
        {
            ilgis = Ilgis;
            spalva = Spalva;
            aukstis = Aukstis;
        }
    }
    class Lektuvai: Trasportas
    {
        public int varikliu_skaicius;
        public int keleiviu_skaicius;
        public string tipas;

            public Lektuvai(int Varikliu_skaicius, int Keleiviu_skaicius, string Tipas,bool ratai, int gamybosmetai, string spalva) : base(ratai, gamybosmetai, spalva)
            {
                varikliu_skaicius = Varikliu_skaicius;
                keleiviu_skaicius = Keleiviu_skaicius;
                tipas = Tipas;
            }
    }



    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Automobiliai.txt");
            System.IO.StreamReader reader1 = new System.IO.StreamReader("Laivai.txt");
            System.IO.StreamReader reader2 = new System.IO.StreamReader("Lektuvai.txt");

            string auto = reader.ReadLine();
            string ship = reader1.ReadLine();
            string plane = reader2.ReadLine();


            string[] autos = auto.Split(' ').ToArray();
            string[] ships = auto.Split(' ').ToArray();
            string[] planes = auto.Split(' ').ToArray();

            Automobilis vrum = new Automobilis(Convert.ToInt32(autos[0]), Convert.ToInt32(autos[1]), autos[2], Convert.ToBoolean(autos[3]), Convert.ToInt32(autos[4]), autos[5]);
            Laivai bhuuuu = new Laivai(Convert.ToInt32(ships[0]), ships[1], Convert.ToInt32(ships[2]), bool.TryParse(ships[3],out bool kintamasis), Convert.ToInt32(ships[4]));
            Lektuvai drrr = new Lektuvai(Convert.ToInt32(planes[0]), Convert.ToInt32(planes[1]), planes[2], Convert.ToBoolean(plane[3]), Convert.ToInt32(planes[4]), planes[5]);

            vrum.uzdarbis(5, 7);
            Console.ReadKey();
        }

        
    }
}
