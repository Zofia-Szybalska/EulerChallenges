using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler5
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long number = 2520;
            for(int dzielnik = 2; dzielnik < 20; dzielnik++)
            {
                if(number % dzielnik != 0)
                {
                    dzielnik = 2;
                    number += 20;
                }
            }
            Console.WriteLine("Result 5 : {0}", number);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
