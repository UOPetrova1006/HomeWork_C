// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
    class Program
    {
        static void Main (string[] args)
        {
            double [] array = new double [123];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine(" ");
            Console.Write("Количество значений в диапазоне от 10 до 99: ");
            HowMuchNumbers(array);
        }
    
    static void CreateArray (double [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
            array[i] = new Random().Next(0,i+1);
            }
        }

    static void WriteArray (double [] array)  
        {
        Console.Write("[" + array[0].ToString());        
        for (int i = 1; i < 121; i++)
            {
            Console.Write(array[i].ToString() + ", ");
            }
        Console.Write(array[122].ToString() + "]");
        }

    static void HowMuchNumbers (double [] array)
    {
        int N = 0;
        int Sum = 0;
        for (int i = 0; i < array.Length; i++)
        if ((array[i] > 10) && (array[i] < 99))
        N++;
        Sum = N + Sum;
        Console.Write(N);
    }    
}