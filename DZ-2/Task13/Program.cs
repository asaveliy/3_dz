﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
    Console.WriteLine($"В числе {num} нет третьей цифры");
else
{
    string str = Convert.ToString(num);
    Console.Write($"Третья цифра: {str[2]} ");
}

