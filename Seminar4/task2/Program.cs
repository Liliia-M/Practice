// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNum(int num)
{
   int ost= 0;
   int result = 0;
   while(num>0)
   {
    ost = num%10;
    
    if(num>10) 
    {
        result = result + ost;
    }     
    else
    {
        result = result + num;
    }
    
    num = num/10;
   }
   return result;    
}

Console.WriteLine("Ведите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNum(number)}");