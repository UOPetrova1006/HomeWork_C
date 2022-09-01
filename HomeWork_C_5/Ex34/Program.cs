// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
    class Program
    {
        static void Main (string[] args)
        {
            double [] array = new double [4];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine(" ");
            Console.Write("Количество четных чисел в массиве: ");
            HowMuchEvenNumbers(array);
        }
    
    static void CreateArray (double [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
            array[i] = new Random().Next(100,999);
            }
        }

    static void WriteArray (double [] array)  
        {
            Console.Write("[");
            for (int i = 0; i < (array.Length-1); i++)
            {
                Console.Write(array[i].ToString() + ", ");
            }
            Console.Write(array[3] + "]");
        }

    static void HowMuchEvenNumbers (double [] array)
    {
        int N = 0;
        int Sum = 0;
        for (int i = 0; i < array.Length; i++)
        if ((array[i] / 2 == 0))
        N++;
        Sum = N + Sum;
        Console.Write(N);
    }    
}