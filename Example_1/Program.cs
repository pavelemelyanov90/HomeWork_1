﻿// Задача 1: нахождение максимального из 2х чисел

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);

int max = number1;
if(number2 > max)
{
    max = number2;
}
Console.WriteLine($"Максимальное число {max}");
