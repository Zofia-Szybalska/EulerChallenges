using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler12_2
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int naturalnumber = 8;
            int trianglenumber = 28;
            int factorsamount = 1;

            while (factorsamount <= 500) {
                trianglenumber += naturalnumber;
                naturalnumber++;
                factorsamount = Helper.GetDivisionOfANumber(trianglenumber);
            }
            Console.WriteLine("Result 12 : {0}", trianglenumber);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}

