using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler4
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int number1 = 999;
            int number2 = 999;
            int max = 0;          
            for (; number1 > 100; number1--, number2 = 999)
            {
                for(var numberToCheck=0; number2 > 100; number2--)
                {
                    numberToCheck = number1 * number2;
                    string numberstring = numberToCheck.ToString();
                    char[] array= numberstring.ToCharArray();
                    Array.Reverse(array);
                    string rev = new string(array);
                    if(rev == numberstring)
                    {
                        if(max < numberToCheck)
                        {
                            max = numberToCheck;
                        }
                    }
                }

            }
            Console.WriteLine("Result 4 : {0}", max);
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
