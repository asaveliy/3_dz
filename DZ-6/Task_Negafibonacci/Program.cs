// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.

// *Пример:*

// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]



void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
}




int[] NegaFibonacci(int[] coll)
{
    int size = coll.Length * 2 - 1;
    int[] newArray = new int[size];
    int middle = Convert.ToInt32(size / 2);
    newArray[middle] = 0;
    for (int i = 1; i <= middle; i++)
    {
        newArray[middle + i] = coll[i];
        newArray[middle - i] = Convert.ToInt32(Math.Pow(-1, i + 1)) * coll[i];
    }
    return newArray;
}



void PrintArray(int[] array)
{
    foreach (int itenumber in array)
        Console.Write($"{itenumber}, ");
    Console.WriteLine();
}



Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Fibonacci(array);
PrintArray(array);
Console.WriteLine(String.Join(", ", NegaFibonacci(array)));


