// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Первая матрица:");
            int[,] array1 = new int [3,2];
            CreateArray(array1);
            int[,] array2 = new int [2,3];
            Console.WriteLine(string.Empty);
            Console.WriteLine("Вторая матрица:");
            CreateArray(array2);
            Console.WriteLine(string.Empty);
            Console.WriteLine("Результирующая матрица:");
            int[,] ResultArray = MultOfMatrix (array1,array2);
            PrintArray(ResultArray);   
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
        static int[,] MultOfMatrix (int [,] array1, int [,] array2)
        {
            if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");

            int[,] ResultArray = new int[array1.GetLength(0), array2.GetLength(1)];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        ResultArray[i,j] += array1[i,k] * array2[k,j];   
                    }
                }
            }
            return ResultArray;            
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