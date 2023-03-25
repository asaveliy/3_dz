// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100);
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



int FindMax(int[] array)
{
    int max = 0;
    foreach (var item in array)
    {
        if (max < item) max = item;
    }
    return max;
}



int FindMin(int[] array)
{
    int min = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
    }
    return min;
}



Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
PrintArray(array);
// Console.WriteLine($"Max = {FindMax(array)}");
// Console.WriteLine($"Min = {FindMin(array)}");
Console.WriteLine($"Разница между min и max значениями = {FindMax(array) - FindMin(array)}");