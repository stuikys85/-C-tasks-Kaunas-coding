using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite keturzenkli skaiciu ir programa ji uzkoduos");
                int skaicius = Convert.ToInt32(Console.ReadLine());
            
            int digit1 =  skaicius / 1000;
            int digit2 = (skaicius % 1000) / 100;
            int digit3 = (skaicius %100) / 10;
            int digit4= skaicius % 10;
            int digit1sum = digit4;
            int digit2sum= digit3;
            int digit3sum = digit2;
            int digit4sum = digit1;

           


            Console.WriteLine(digit1sum+""+digit2sum+""+digit3sum+""+digit4sum);
            
            Console.ReadKey();

        }
    }
}
