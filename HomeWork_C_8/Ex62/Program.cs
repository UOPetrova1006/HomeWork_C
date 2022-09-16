// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
    class Program
    {
        static void Main (string[] args)
        {
            int [,] array = new int [4,4];
            CreateArray(array);
            Console.WriteLine(string.Empty);
            int[,] SpirallArray = SpiralFulfilment(array);
            PrintArray(SpirallArray);
        }
        static void CreateArray(int [,] array)
        { 
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i, j] = random.Next(0,9+i);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int [,] SpiralFulfilment(int [,] array)
        {
            var SizeX = array.GetLength(0);
            var SizeY = array.GetUpperBound(1);
            var maxX = SizeX+1;
            var maxY = SizeY;
            var dirX = 1;
            var dirY = 1;
            var x = -1;
            var y = 0;
            var val = 1;
            while ((maxX >= 0) && (maxY >= 0))
            {
                for (int xval = 1; xval <= maxX; xval++)
                {
                    array[x + dirX * xval, y] = val;
                    val++;
                }
                x = x + dirX * maxX;
                dirX = -dirX;
                maxX--;
                for (int yval = 1; yval <= maxY; yval++)
                {
                    array[x, y + dirY * yval] = val;
                    val++;
                }
                y = y + dirY * maxY;
                dirY = -dirY;
                maxY--;
            }
            return array;
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }