// Задача HARD SORT необязательная. Считается за три обязательных 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 20);
}



int[,] SortArray(int[,] arr, int[,] matr, int n, int m)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            while (n < arr.GetLength(0) - 1 && m < arr.GetLength(1) - 1)
                if (matr[n, m] < arr[i, j])
                {
                    matr[n, m] = arr[i, j];
                }
return matr;
}





void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[,] matrix = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine("отсортированный массив:");
SortArray(array, matrix, rows, cols);
PrintArray(matrix);

// int smaller = array[1,0];
// Console.WriteLine(smaller);
