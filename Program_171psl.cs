using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp149
{
    class Mokykla
    {
        //duomenys
        public int klases_skaicius;
        public char klases_raide;
        public int mokiniu_skaicius;
        public int mok_pradz_skaicius;


        // Konstruktorius
        public Mokykla(string klases_kaicius, char klases_raide, int mokiniu_skaicius, int mok_pradz_skaicius)
        {
            Klases_kaicius = klases_kaicius;
            Klases_raide = klases_raide;
            Mokiniu_skaicius = mokiniu_skaicius;
            Mok_pradz_skaicius = mok_pradz_skaicius;
        }
    public Mokykla()
    {

    }
    public mokykla(int viso_metu, int kiek_metu_mokosi)
    {
            viso_metu = mok_pradz_skaicius + klases_skaicius;
            kiek_metu_mokosi = viso_metu - mok_pradz_skaicius;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mokykla auto = new Mokykla(10,'F', 24, 2009);
            Console.WriteLine(Mokykla());
            Console.ReadKey();

            
        }
    }
}
