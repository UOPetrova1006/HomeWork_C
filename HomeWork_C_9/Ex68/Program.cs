// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение функции Аккермана для аргументов {N} до {M}:");
            Console.WriteLine(AkkermanFunction(N,M));
            Console.ReadKey();
        }        
        static int AkkermanFunction(int n, int m)
        {
            if (n == 0) return m + 1;
            if (n != 0 && m == 0) return AkkermanFunction(n - 1, 1);
            if (n > 0 && m > 0) return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
            return AkkermanFunction(n,m);
        }
    }