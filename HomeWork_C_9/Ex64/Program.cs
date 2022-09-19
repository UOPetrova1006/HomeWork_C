// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System;
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Все натуральные числа от {M} до {N}:");
            NaturalNumbers(M,N);
        }
        static void NaturalNumbers (int M, int N)
        {
            int i = 1;
            for (int count = 1; i < N-1; count++)
            {
                i = M + i;
                Console.WriteLine(i);
            }
        }
    }