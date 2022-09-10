// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int PositiveNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите M чисел: ");
int M = int.Parse(Console.ReadLine());
int[] myArray = GetArray(M,-100, 100);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(PositiveNum(myArray));