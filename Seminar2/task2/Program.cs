//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int theThirdNumber = num / 100;
int result = theThirdNumber % 10;

if (num >= 100)
{
    Console.WriteLine($"{num}->{theThirdNumber}");
}
else
{
    Console.WriteLine($"{num}-> третьей цифры нет");
}
if (theThirdNumber >= 10)
{
    Console.WriteLine($"{num}->{result}");
}
