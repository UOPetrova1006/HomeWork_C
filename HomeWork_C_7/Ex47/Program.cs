﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите размер массива M x N.");
            Console.WriteLine("Введите M:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());
            
            double [,] array = new double [M,N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array [i, j] = random.NextDouble()*100;
                    Console.Write("{0,6:F2}",array[i,j]);
                }
                Console.WriteLine();
            }
        }
    }