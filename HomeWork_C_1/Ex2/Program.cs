﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

while (true)
{
    Console.WriteLine("Введите s для продолжения или q для выхода");
    string Operator = Console.ReadLine();
     if (Operator == "q")
     {
        break;
     }
     else if (Operator == "s")
     {
        Console.WriteLine("Введите 1 число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"max = {a}");
        }
        else if (a < b)
        {
            Console.WriteLine($"max = {b}");
        }
    }
}