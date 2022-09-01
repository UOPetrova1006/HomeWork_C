// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using System;
    class Program
    {
        static void Main (string[] args)
        {
            double [] array = new double [7];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine(" ");
            Multiplication(array);   
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

    static void Multiplication(double [] array)
    {
        int length = array.Length / 2;
        if (array.Length % 2 == 1) length++;
        double[] Mult = new double [length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            Mult[i] = array[i] * array[array.Length-1-i];
        }
        if (array.Length % 2 == 1) Mult[length-1] = array[array.Length / 2];
        for (int i = 0; i < Mult.Length; i++)
        {
            Console.Write (Mult[i].ToString() + " ");
        }   
    }
}

