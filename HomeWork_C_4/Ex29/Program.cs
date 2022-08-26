// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите числа через запятую");
            string numbers = Console.ReadLine();
            
            string[] NumArray = numbers.Split(',');
            Console.Write("[ ");

            for (int i = 0; i <= NumArray.Length-1; i++)
            {
                Console.Write(NumArray[i] + ", ");
            }
            Console.Write(NumArray[NumArray.Length-1] + " ]");
        }
    }