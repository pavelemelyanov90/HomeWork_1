// Задача 3 : определение чётности введённого числа

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if(number % 2 == 0) // % показывает остаток от деления 
{
    Console.WriteLine($"Число {number} чётное");
}
else
{
    Console.WriteLine($"Число {number} нечётное");
}
