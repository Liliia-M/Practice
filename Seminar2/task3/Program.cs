//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine($"{num} -> да ");
}
if (num >= 1 && num <= 5 )
{
    Console.WriteLine($"{num} -> нет ");
}
if (num <= 0 || num > 7 )
{
    Console.WriteLine($"{num} -> данная цифра не обозначает день недели, необходимо вводить цифру от 1 до 7 ");
}
