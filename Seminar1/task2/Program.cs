//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

int max = 0;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное из трёх чисел = {max}");