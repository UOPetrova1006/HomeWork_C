﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

while (true)
{
    Console.WriteLine("Введите start для продолжения или quit для выхода");
    string Operator = Console.ReadLine();
     if (Operator == "quit")
     {
        break;
     }
     else if (Operator == "start")
     {
        Console.WriteLine("Введите 1 число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 3 число");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.Write("max = ");
        Console.WriteLine(max);
     }
}