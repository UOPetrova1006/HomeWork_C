// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
namespace BabbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,] array = new int [5,5];
            CreateArray(array);
            Console.WriteLine("Исходный массив");
            PrintArray(array);
            Console.WriteLine("Сортировка по строкам: ");
            int[] row = new int[array.GetLongLength(0)];
            for (int i = 0; i < array.GetLongLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                    row[j] = array[i, j];
                BubbleSort(row);
                Insert(true, i, row, array);
            }
            PrintArray(array);
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        static void CreateArray(int [,] array)
        { 
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i, j] = random.Next(0,9+i);
                }
            }
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
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] < inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
    }
}