﻿//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
int z2 = int.Parse(Console.ReadLine());

double pow1 = Math.Pow((x1 - x2), 2);
double pow2 = Math.Pow((y1 - y2), 2);
double pow3 = Math.Pow((z1 - z2), 2);

double sum = pow1 + pow2 + pow3;

double result = Math.Sqrt(sum);

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {result:f2}");