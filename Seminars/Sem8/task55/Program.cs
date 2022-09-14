// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] tempArray = new int [array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempArray[j, i] = array[i, j];
            }
        }
        return tempArray;
    }
    else
    {
        Console.WriteLine("Невозможно поменять местами строки и столбцы");
        return array;
    }
}

int[,] myArray = GetArray(3, 3, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int[,] newArray = SwapRowsAndColumns(myArray);
PrintArray(newArray);