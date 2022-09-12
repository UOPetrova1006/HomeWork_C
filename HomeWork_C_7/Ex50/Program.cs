// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
 // 17 -> такого числа в массиве нет

using System;
    class Program
    {
        static void Main (string[] args)
        {
            int [,] array = new int [5,5];
            CreateArray(array);
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            FindInArray(array,number);
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
        static void FindInArray (int [,] array, int number)
        {   
            int m = 0, n = 0;
            bool f = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ( number == array[i,j]) {m = i; n = j; f = true;};
                    Console.Write("{0}\t", array[i,j]);
                }
            Console.WriteLine(); 
            }
            Console.WriteLine();
            if (f)
                Console.WriteLine($"Число найдено.Строка {m+1} Столбец {n+1}");
            else
                Console.WriteLine("Число не найдено");
            Console.ReadKey();
        }
    }