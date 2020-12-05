using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler3
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            long liczba = 600851475143;
            long sum = 0;
            int p = 2;
                while (liczba > 1)
                {
                if (liczba % p == 0)
                {
                    liczba /= p;
                    if (p > sum)
                    {
                        sum = p;
                    }
                }
                else
                {
                    p++;
                }
                }
   
            Console.WriteLine("Result 3 : {0}", sum);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
