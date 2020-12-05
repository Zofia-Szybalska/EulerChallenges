using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler1
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Result 1 : {0}", sum);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
