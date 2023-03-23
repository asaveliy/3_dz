// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int min = Convert.ToInt32(Console.ReadLine());

if (max > min)
{
    Console.WriteLine("max = " + max);
    Console.WriteLine("min = " + min);
}
else
{
    Console.WriteLine("max = " + min);
    Console.WriteLine("min = " + max);
}
