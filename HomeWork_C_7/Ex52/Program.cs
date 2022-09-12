// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
    class Program
    {
        static void Main (string[] args)
        {
            int [,] array = new int [5,5];
            CreateArray(array);
            AverageOfRow(array);
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
        static void AverageOfRow (int [,] array)
        {   
            int [] sum = new int[array.GetLength(0)];
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum[j] = 0;
                double Average = 0;
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    sum[j] += array[i,j];
                    Average = sum[j]/sum.Length+1;
                }
                Console.Write("Среднее значение в столбце № " + j.ToString() + " равно: ");
                Console.WriteLine(Average);
            }            
        }
    }