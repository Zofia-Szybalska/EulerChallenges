using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler9
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int a = 1;
            int b = 2;
            int c = 0;
            bool check = false;
            for (;a < 333 ; a++ )
            {
                for ( b = 2; b < 500 ; b++ ) 
                {
                    if (Math.Sqrt(b * b + a * a) % 1 == 0)
                    {
                        c = (int)Math.Sqrt(b * b + a * a);
                        if (a + b + c == 1000 && b < c)
                        {
                            check = true;
                            break;
                        }
                    }
    

                }
                if (check)
                {
                    break;
                }
            }
            
            long product = a * b * c;
            Console.WriteLine("Result 9 : {0}", product);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
