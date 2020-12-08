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
            List<long> primenumbers = new List<long>();
            primenumbers.Add(2);
            while( primenumbers[primenumbers.Count()-1] < 2000000)
            {
                for (int dzielnik = 2; dzielnik <= Math.Sqrt(number) + 1; dzielnik++)
                {
                    if (number % dzielnik == 0)
                    {
                        number++;
                        dzielnik = 1;
                    }
                    else if (number % dzielnik != 0 && dzielnik >= Math.Sqrt(number))
                    {
                        primenumbers.Add(number);
                        number++;
                        break;
                    }

                }

            }
            if(primenumbers[primenumbers.Count() - 1] > 2000000)
            {
                primenumbers.RemoveAt(primenumbers.Count() - 1);
            }
            Console.WriteLine("Result 10 : {0}", primenumbers.Sum());
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
