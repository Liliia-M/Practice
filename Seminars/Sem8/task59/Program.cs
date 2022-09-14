// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindMinimum(int[,] array, int [] minArray)
{
    int minNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minNumber > array[i, j])
            {
                minNumber = array[i, j];
                minArray[0] = i;
                minArray[1] = j;
            }
            
        }
    }
    return minArray;
}

int[,] ChangeArray(int[,] array, int[] deleteArray)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != deleteArray[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != deleteArray[1])
                {
                    result[l, k] = array[i, j];
                    k++;
                }
            }
            k = 0;
            l++;
        }
        
    }
    return result;
}


int[,] myArray = GetArray(5, 5, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int[] minimumPositions = new int[2];
minimumPositions = FindMinimum(myArray, minimumPositions);

int[,] resultArray = ChangeArray(myArray, minimumPositions);
Console.WriteLine();
PrintArray(resultArray);
