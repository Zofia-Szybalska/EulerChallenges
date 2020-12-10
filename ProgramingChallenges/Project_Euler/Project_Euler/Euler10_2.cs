using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Euler10_2
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew(); 
            List<long> primenumbers = new List<long>();
            primenumbers.Add(2);
            for (int number = 3; number < 2000000; number++)
            {
                foreach (int primenumber in primenumbers)
                {
                    if (number % primenumber == 0)
                    {
                        break;
                    }
                    else if (primenumber > Math.Sqrt(number))
                    {
                        primenumbers.Add(number);
                        break;
                    }
                }
            }
            Console.WriteLine("Result 10_2 : {0}", primenumbers.Sum());
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);

        }
    }
}
