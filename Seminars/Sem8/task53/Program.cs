//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] Swap1andLastRow(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temporary = array[0, i];
        array[0, i] = array[lastRowIndex, i];
        array[lastRowIndex, i] = temporary;

    }
    return array;
}


int[,] myArray = GetArray(3, 3, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int[,] newArray = Swap1andLastRow(myArray);
PrintArray(myArray);