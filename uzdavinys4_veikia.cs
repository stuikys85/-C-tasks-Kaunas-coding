using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp162
{
    class Mokykla
    {
        // klase mokykla ir kintamieji.
        public int klases_skaicius = 10;
        public char klases_raide = 'F';
        public int mokiniu_skaicius = 24;
        public int mokimosi_prad_sk = 2009;
        public int praejo_metu;

        //metodas kaip apskaiciuot kiek mokinosi.

        class program
        {

             static void Main(string[] args)
            {


                int mokimosi_prad_sk = 2009;
                int klases_skaicius = 10;
                int preajo_metu =mokimosi_prad_sk +  klases_skaicius;
                int kiek_laiko = preajo_metu - mokimosi_prad_sk;
                Console.WriteLine("mokiniai mokinosi:"+kiek_laiko +" metu.\n"+ "klaseje:\n"+klases_skaicius+""+'F');
                Console.ReadKey();
 }
            



        }
        public virtual void Mokykla2()
        {
            int mokimosi_prad_sk = 2009;
            int klases_skaicius = 10;
            int preajo_metu = mokimosi_prad_sk + klases_skaicius;
            int kiek_laiko = preajo_metu - mokimosi_prad_sk;
            

        }
        






        static void main(string[] args)
        {

        }
        

    }
    

}

