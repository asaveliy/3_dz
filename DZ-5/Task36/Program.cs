// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-99, 100);
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



int CountSum(int[] coll)
{
    int sum = 0;
    for (int i = 0; i < coll.Length; i += 2)
    {
        sum += coll[i];
    }
    return sum;
}




Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма цифр на нечетных позициях = {CountSum(array)}");



