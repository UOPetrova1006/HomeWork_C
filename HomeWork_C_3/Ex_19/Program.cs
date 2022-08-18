// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
class Program
{
    public static void Main () 
    {
        Console.WriteLine("Введите пятизначное число");
        int num = Convert.ToInt32(Console.ReadLine());
        string numbers = num.ToString();
        char[] chars = numbers.ToCharArray();
        if (numbers[0] == numbers[4] || numbers[1] == numbers[3])
        {
            Console.WriteLine("да");    
        }
        else
        {
             Console.WriteLine("нет"); 
        }                           
    }
}