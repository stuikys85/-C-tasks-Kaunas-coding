﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            masyvas[0] = 1;
            masyvas[1] = 1;
            for(int i =2; i < 10; i++)
            {
                masyvas[1] = masyvas[i - 1] + masyvas[i - 2];
            }
            foreach(int sk in masyvas)
            {
                Console.WriteLine(sk);
            }
            Console.ReadKey();
        }
    }
}
