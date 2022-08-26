// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
class Program
{
    public static void Main () 
    {
        Console.WriteLine("Введите число");
        string num = Console.ReadLine();
        
        int Sum = 0;
        for (int index = 0; index < num.Length; index++)
            {
            Sum = Convert.ToInt32(num[index].ToString()) + Sum;
            }
             
        Console.WriteLine($"Сумма цифр числа равна {Sum}");
    }
} 