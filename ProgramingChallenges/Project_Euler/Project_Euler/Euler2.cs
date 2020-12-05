using System;
using System.Diagnostics;

namespace Project_Euler
{
    internal class Euler2
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew(); 
            int l1 = 1;
            int l2 = 2;
            int sum = 0;
            while (l1 < 4000000 && l2 < 4000000)
            {
                if (l1 % 2 == 0)
                {
                    sum += l1;
                }
                else if (l2 % 2 == 0)
                {
                    sum += l2;
                }
                l1 += l2;
                l2 += l1;
            }
            Console.WriteLine("Result 2 : {0}", sum);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}