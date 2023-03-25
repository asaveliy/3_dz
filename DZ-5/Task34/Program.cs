// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 999);
    }
}



void PrintArray(int[] collection)
{
    foreach (var position in collection)
    {
        Console.Write($"{position} ");
    }
    Console.WriteLine();
}




int CountEven(int[]collection)
{
    int count = 0;
    foreach (int item in collection)
    {
        if (item%2 == 0) count++;
    }
    return count;
}





Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Среди элементов этого массива {CountEven(array)} четных чисел'");

