// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
class Program
{
    public static void Main () 
    {
        Console.WriteLine("Введите координаты точки A по оси x");
        int x1  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки A по оси y");
        int y1  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки A по оси z");
        int z1  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B по оси x");
        int x2  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B по оси y");
        int y2  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B по оси z");
        int z2  = Convert.ToInt32(Console.ReadLine());
        
        double X = Math.Pow((x1-x2),2);
        double Y = Math.Pow((y1-y2),2);
        double Z = Math.Pow((z1-z2),2);

        double SumXYZ = X + Y + Z;

        double DistanceAB = Math.Round((Math.Abs(Math.Sqrt(SumXYZ))),2);

        Console.WriteLine(DistanceAB);                      
    }
}