// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;
class Program
{
    public static void Main () 
    {
        Console.WriteLine("Введите трехзначное число");
        string num = Console.ReadLine();

        char[] chars = num.ToCharArray();

        Console.WriteLine("Вторая цифра заданного числа:" + chars[1]);           
    }
} 