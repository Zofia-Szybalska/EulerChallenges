using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler6
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long squaresum = 0;
            long sum = 0;
            long wynik;
            for (int number = 1; number < 101; number++)
            {
                squaresum = squaresum + number * number;
            }
            for (int number = 1; number < 101; number++)
            {
                sum += number;
            }
            wynik =sum * sum - squaresum;
            Console.WriteLine("Result 6 : {0}", wynik);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
