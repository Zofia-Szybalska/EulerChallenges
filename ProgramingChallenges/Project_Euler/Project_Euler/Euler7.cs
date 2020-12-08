using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler7
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long number = 2;
            List<long> primenumbers = new List<long>();
            primenumbers.Add(2);
            for(int count = 10000; count != 0; count--)
            {
                for (int dzielnik = 2; dzielnik <= Math.Sqrt(number) + 1; dzielnik++)
                {
                    if (number % dzielnik == 0)
                    {
                        number++;
                        dzielnik = 1;
                    }
               
                }
                primenumbers.Add(number);
                number++;

            }
            Console.WriteLine("Result 7 : {0}", primenumbers[10000]);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);

        }
    }
}
