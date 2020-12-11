using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Euler11
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[,] numbers = new int[20, 20];
            string[] lines = File.ReadAllLines("./Euler11.txt");
            for(int i =0; i < lines.Length; i++)
            {
                List<int> numbersList = new List<int>(Array.ConvertAll(lines[i].Split(' '), int.Parse));
                for(int j = 0; j < 20; j++)
                {
                    numbers[i,j] = numbersList[j];
                }
            }
            int vertical = GetMaxVerticalProduct(numbers);
            int horizontal = GetMaxHorizontalProduct(numbers);
            int diagonall = GetMaxDiagonallyProduct(numbers);
            List<int> maxproducts = new List<int> {vertical, horizontal, diagonall};
            Console.WriteLine("Result 12 : {0}", maxproducts.Max());
            stopwatch.Stop();
            Console.WriteLine("Time : {0}", stopwatch.Elapsed);
        }
        private static int GetMaxHorizontalProduct(int[,] array)
        {
            int maxproduct = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1)-3; j++)
                {
                    int product = array[i, j] * array[i, j + 1] * array[i, j + 2] * array[i, j + 3];
                    maxproduct = Math.Max(maxproduct, product);
                }
            }
            return maxproduct;
        }
        private static int GetMaxVerticalProduct (int[,] array)
        {
            int maxproduct = 0;
            for(int i = 0; i < array.GetLength(0)-3; i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    int product = array[i, j] * array[i + 1, j] * array[i + 2, j] * array[i + 3, j];
                    maxproduct = Math.Max(maxproduct, product);
                }
            }
            return maxproduct;
        }
        private static int GetMaxDiagonallyProduct(int[,] array)
        {
            int maxproduct = 0;
            for (int i = 0; i < array.GetLength(0)-3; i++)
            {
                for(int j = 0; j < array.GetLength(1)-3; j++)
                {
                    int product = array[i, j] * array[i+1, j+1] * array[i+2, j+2] * array[i+3, j+3];
                    maxproduct = Math.Max(maxproduct, product);
                }
            }
            for(int i = 0; i < array.GetLength(0)-3; i++)
            {
                for(int j = array.GetLength(1)-1; j > 2; j--)
                {
                    int product = array[i, j] * array[i + 1, j - 1] * array[i + 2, j - 2] * array[i + 3, j - 3];
                    maxproduct = Math.Max(maxproduct, product);
                }
            }
            return maxproduct;
        }



    }
}
