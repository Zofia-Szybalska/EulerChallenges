using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;

namespace Project_Euler
{
    class Euler13
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string[] lines = File.ReadAllLines("./Euler13.txt");
            BigInteger[] numbers = new BigInteger[lines.Length];
            for (int i =0; i < lines.Length; i++)
            {
                numbers[i] = BigInteger.Parse(lines[i]);
            }
            BigInteger sum = 0;
            foreach (BigInteger number in numbers)
            {
                sum += number;
            }
            string sumstring = sum.ToString();
            Console.WriteLine("Result 13 : {0}", sumstring.Substring(0,10));

            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
    }
}
