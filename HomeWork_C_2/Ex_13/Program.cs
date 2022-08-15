// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
class Program
{
    public static void Main () 
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
               
        if (num < 100)
        {
            Console.WriteLine("Третьей цифры нет");    
        }
        else if (num > 99)
        {
            string numbers = num.ToString();
            char[] chars = numbers.ToCharArray();
            Console.WriteLine("Третья цифра заданного числа:" + chars[2]);           
        }
    }
}