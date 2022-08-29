// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число B: ");
// int count = int.Parse(Console.ReadLine());

// int i = 1;
// int result = 1;

// while (i<=count)
// {
//     result = result * num;
//     i++;
// }

// Console.WriteLine($"{result}");


//==========================================


Console.WriteLine("Введите число A: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int count = int.Parse(Console.ReadLine());

int GetNumber(int number)
{
    int i = 1;
    int result = 1;
    for(i = 1; i <= count; i++)
    {
        result = result * num;
    }
    return result;
}

Console.WriteLine($"{num}, {count} -> {GetNumber(num)}");

