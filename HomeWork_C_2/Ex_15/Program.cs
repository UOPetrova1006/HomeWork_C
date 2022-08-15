// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
using System;
class Program
{
    static void WriteSelect(string[] DaysArray)
    {
        for (int i = 0; i < DaysArray.Length-1; i++)
        {
            Console.Write(i+1 + " - " + DaysArray[i] + ", ");
        }
        Console.WriteLine(DaysArray.Length + " - " + DaysArray[DaysArray.Length-1] + ".");
    }
    static void SelectDay()
    {
        string [] NumberOfDay = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
        WriteSelect(NumberOfDay);
        Console.WriteLine("Укажите номер дня недели");
        int indexDays = Convert.ToInt32(Console.ReadLine());
        if ((indexDays-1) < 5)
        {
                Console.WriteLine("будний день");     
        }
        else if ((indexDays-1) > 5)
        {
                Console.WriteLine("выходной");     
        }
    }
    static void Main(string[] args)
    {
       SelectDay();   
    }
}