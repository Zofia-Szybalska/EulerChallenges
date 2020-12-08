using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Helper
    {
        public static long GetPrimeNumber(int witchnumber)
        {
            int number = 3;
            int primenumber = 2;
            for (int count = witchnumber -1; count != 0; count--)
            {
                for (int dzielnik = 2; dzielnik <= Math.Sqrt(number) + 1; dzielnik++)
                {
                    if (number % dzielnik == 0)
                    {
                        number++;
                        dzielnik = 1;
                    }

                }
                primenumber = number;
                number++;

            }
            return primenumber;
        }
        public static long GetPrimeNumbersSum(int towitchnumber)
        {
            int number = 3;
            List<long> primenumbers = new List<long>();
            primenumbers.Add(2);
            for (int count = towitchnumber - 1; count != 0; count--)
            {
                for (int dzielnik = 2; dzielnik <= Math.Sqrt(number) + 1; dzielnik++)
                {
                    if (number % dzielnik == 0)
                    {
                        number++;
                        dzielnik = 1;
                    }

                }
                primenumbers.Add(number);
                number++;

            }
            return primenumbers.Sum();
        }

        public static long GetNaturalNumbersSum(int towitchnumber)
        {
            int naturalnumber = 1;
            long sum = 0;
            for(int count = towitchnumber; count != 0; count-- , naturalnumber++)
            {
                sum += naturalnumber;
            }
            return sum;
        }
    }
}
