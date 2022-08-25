//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
//int count = 1;

//while (count <= num)
//{
//    double pow = Math.Pow(count,3);
//    Console.Write($"{pow}, ");
//    count++;
//}

for(int i=1; i<=num; i++)
{
    //Console.Write($"{i*i*i}, ");
    Console.Write($"{Math.Pow(i,3)}, ");
}
Console.WriteLine();
