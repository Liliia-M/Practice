// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

Console.WriteLine("Введите число N, соответствующее числу элементов массива: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число a, соответствующее возможному наименьшему из массива: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b, соответствующее возможному наибольшему из массива: ");
int b = int.Parse(Console.ReadLine());

int [] InitArray()
{
    int[] arr = new int[N];
    for(int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(a, b+1);
    }
    return arr;
}

Console.WriteLine(String.Join(", ", InitArray()));


