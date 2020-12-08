using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler12
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int trianglenumbersnumber = 8;
            long trianglenumber = 0;
            for(int factorsamount = 2; factorsamount < 500; trianglenumbersnumber++)
            {
                factorsamount = 2;
                trianglenumber = Helper.GetNaturalNumbersSum(trianglenumbersnumber);
                for(int factor = 2; factor < trianglenumber; factor++)
                {
                    if(trianglenumber % factor == 0)
                    {
                        factorsamount++;
                    }
                }

            }
            Console.WriteLine("Result 12 : {0}", trianglenumber);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
