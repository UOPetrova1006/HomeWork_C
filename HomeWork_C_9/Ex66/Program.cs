// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using System.Linq;
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int N = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}:");
            SumOfNaturalNumbers(M, N);
        }
        static void SumOfNaturalNumbers (int M, int N)
        {
            int[] array = Enumerable.Range(M, N).ToArray(); 
            int sum = 0;
            foreach (int value in array)
            {
            sum += value;
            }
            Console.WriteLine(sum);
        }
    }