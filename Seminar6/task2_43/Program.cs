// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Point(double num1, double num2, double num3, double num4)
{
    double[] res = new double [2];
    res[0] = (num3 - num1)/(num2 - num4);
    res[1] = num2*res[0] + num1;
    return res;
}

Console.WriteLine("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine());

double[] result = Point(b1,k1,b2,k2);
Console.WriteLine(String.Join(" ", result));