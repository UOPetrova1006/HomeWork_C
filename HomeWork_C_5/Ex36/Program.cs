// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
    class Program
    {
        static void Main (string[] args)
        {
            double [] array = new double [4];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine(" ");
            Console.Write("Сумма элементов на нечетных позициях: ");
            SumOfUneven(array);
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
            Console.Write("[");
            for (int i = 0; i < (array.Length-1); i++)
            {
                Console.Write(array[i].ToString() + ", ");
            }
            Console.Write(array[3] + "]");
        }

    static void SumOfUneven (double [] array)
    {
        double Sum = 0;
        for (int i = 0; i < array.Length; i++)
        if ((i % 2 == 0))
        {}        
        else
        {
         
         Sum = array[i] + Sum;   
        }
        Console.Write(Sum);
    }    
}