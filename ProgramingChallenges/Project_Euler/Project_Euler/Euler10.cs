using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Euler10
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long number = 2;
            long primenumberssum = 0;
            while( number < 2000000)
            {
                primenumberssum += number;
                number++;
                for (int dzielnik = 2; dzielnik <= Math.Sqrt(number) + 1; dzielnik++)
                {
                    if (number % dzielnik == 0)
                    {
                        number++;
                        dzielnik = 1;
                    }                    

                }

            }
            Console.WriteLine("Result 10 : {0}", primenumberssum);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
