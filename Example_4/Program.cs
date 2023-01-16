// Задача 4 : чётные числа от 1го до N

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int count = 1;

while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.WriteLine($" {count} ");
        count++;
    }
    else
    {
        count++;
    }
}
