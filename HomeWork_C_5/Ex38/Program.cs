// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
using System;
    class Program
    {
        static void Main (string[] args)
        {
            double [] array = new double [7];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine(" ");
            FindDiff(array);
               
        }
    
    static void CreateArray (double [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
            array[i] = new Random().Next(0,10);
            }
        }

    static void WriteArray (double [] array)  
        {
            Console.Write("[");
            for (int i = 0; i < (array.Length); i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.Write("]");
        }

    static void FindDiff (double [] array)
    {
        double Max = array [0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > Max)
            {
                Max = array[i];
            }
        }
           
            double Min = array [0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < Min)
            {
                Min = array[i];
            }
        }
        double Diff = Max - Min;
        Console.WriteLine(Diff);
        Console.ReadLine();
    }
}   