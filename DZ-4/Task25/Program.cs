// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// вариант 1: РЕШЕНИЕ

Console.WriteLine("Введите число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень:");
double b = Convert.ToDouble(Console.ReadLine());
int n = Convert.ToInt32(b);

Console.WriteLine($"Число {a} в натуральной степени от {b} (т.е. {n}) = {Math.Pow(a, n)}");



// вариант 2: РЕШЕНИЕ С ИСПОЛЬЗОВАНИЕМ МЕТОДА


// double GetNum(string text)
// {
//     Console.WriteLine(text);
//     double num = double.Parse(Console.ReadLine());
//     return num;
// }

// double a = GetNum("Введите число:");

// double b = GetNum("В какую степень будем возводить?");

// Console.WriteLine(Math.Round(Math.Pow(a, b), 1));




