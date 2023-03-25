// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив 
// и вывести на экран с пояснениями. Найти медианное значение первоначалального 
// массива , возможно придется кое-что для этого дополнительно выполнить.



void FillArray(int[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().Next(1, 100);
    }
}




void PrintArray(int[] coll)
{
    foreach (var position in coll)
    {
        Console.Write($"{position} ");
    }
    Console.WriteLine();
}





int[] FindMinMax(int[] array, int[] resultArray)
{
    int max = array[0];
    int min = array[0];
    int indexMin = 0;
    int indexMax = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            indexMax = i;
        }
        else if (min > array[i])
        {
            min = array[i];
            indexMin = i;
        }
    }
    resultArray[0] = max;
    resultArray[1] = indexMax;
    resultArray[2] = min;
    resultArray[3] = indexMin;
    return resultArray;
}




int AvArray(int[] arr)
{
    int countAver = 0;
    foreach (int item in arr)
    {
        countAver += item;
    }
    countAver /= arr.Length;
    return countAver;
}




int[] SortArray(int[] coll)
{
    int size = coll.Length;
    for (int current = 0; current < size - 1; current++)
    {
        for (int i = 0; i < size - 1 - current; i++)
        {
            if (coll[i] > coll[i + 1])
            {
                int temp = coll[i];
                coll[i] = coll[i + 1];
                coll[i + 1] = temp;
            }
        }
    }
    return coll;
}




int Mediana(int[] arr)
{
    int mediana = 0;
    if (arr.Length % 2 == 0)
    {
        mediana = (arr[(arr.Length - 1) / 2] + arr[((arr.Length - 1) / 2) + 1]) / 2;
    }
    else
    {
        mediana = arr[arr.Length / 2];
    }
    return mediana;
}




Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
int[] resultArray = new int[5];
FillArray(array);
PrintArray(array);
resultArray = FindMinMax(array, resultArray);
resultArray[4] = AvArray(array);
array = SortArray(array);
Console.WriteLine($"{resultArray[0]} -> максимальное значение");
Console.WriteLine($"{resultArray[1]} -> индекс максимального значения");
Console.WriteLine($"{resultArray[2]} -> минимальное значение");
Console.WriteLine($"{resultArray[3]} -> индекс минимального значения");
Console.WriteLine($"{resultArray[4]} -> среднее арифметическое значение");
Console.WriteLine($"{Mediana(array)} -> медианное значение");