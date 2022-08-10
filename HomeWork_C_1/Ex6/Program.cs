// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

while (true)
{
    Console.WriteLine("Введите start для продолжения или quit для выхода");
    string Operator = Console.ReadLine();
     if (Operator == "quit")
     {
        break;
     }
     else if (Operator == "start")
     {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine());
                
        if (a % 2 == 0)
        {
            Console.WriteLine("чётное");
        }
        else 
        {
        Console.WriteLine("нечётное");
        }
    }
}