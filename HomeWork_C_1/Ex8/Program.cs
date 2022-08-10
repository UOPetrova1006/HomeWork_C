// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все чётные числа от 1 до вашего числа:");
int index = 1;

while (index < N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
    }
    index++;
}