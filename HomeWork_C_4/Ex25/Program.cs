// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

    class Program
    {
        static void Main ()
        {
        Console.WriteLine("Введите число");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень для возведения вашего числа");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{A} в степени {B} равно:"); 
        Console.Write(Degree (A, B)); 
        }
       static int Degree (int A, int B)
       {
       int Mult = 1;
       for (int i = 1; i <= B; i++)
            {
            Mult = A * Mult;
            }
            return Mult;
        } 
    }