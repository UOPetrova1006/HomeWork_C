// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
    class Program
    {
        static void Main (string[] args)
        {
            int [,] array = new int [7,5];
            CreateArray(array);
            SumOfRow(array);
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
        static void SumOfRow (int [,] array)
        {   
            int [] sum = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum[i] = 0;
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum[i] += array[i,j];
                }   
                // Console.Write("Сумма элементов в строке № " + i.ToString() + " равна: ");
                // Console.WriteLine(sum[i]);
            } 
             int MinimalRow = sum.Min();  
             int Min = Array.FindIndex(sum, x => x == MinimalRow);
            Console.WriteLine($"Строка с наименьшей суммой элементов: {Min+1}"); 
        }  
    }