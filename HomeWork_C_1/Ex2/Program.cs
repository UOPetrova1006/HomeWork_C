// Задача 2. Ввести 2 числа, вывести максимум и минимум.

while (true)
{
    Console.WriteLine("Введите s для продолжения или q для выхода");
    string Operator = Console.ReadLine();
     if (Operator == "q")
     {
        break;
     }
     else if (Operator == "s")
     {
        Console.WriteLine("Введите 1 число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"max = {a}");
        }
        else if (a < b)
        {
            Console.WriteLine($"max = {b}");
        }
    }
}