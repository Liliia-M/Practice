﻿//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Строки и массивы использовать нельзя!
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int firstNum = num/10000;
int secondNum = (num/1000)%10;
int fourthNum = (num/10)%10;
int fifthNum = num%10;

if(firstNum == fifthNum && secondNum == fourthNum)
{
    Console.WriteLine($"{num} -> да");
}
else{
    Console.WriteLine($"{num} -> нет");
}