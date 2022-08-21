//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine());

int max = -10;
int min = 10;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberA < min) min = numberA;
if (numberB < min) min = numberB;

Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");