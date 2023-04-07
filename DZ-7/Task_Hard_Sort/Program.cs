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




int[,] SortArray(int[,] arr)
{
    int temp = arr[0, 0];
    for (int i = 0; i < arr.GetLength(1); i++)  // 3. повторно запускает (2) и следовательно (1) до победного
        for (int j = 0; j < arr.GetLength(0); j++) // 2. переключает строки и снова запускает (1) 
            for (int k = 1; k < arr.GetLength(1); k++) // 1. запускает проверку по строке
                if (temp > arr[j, k])
                {
                    temp = arr[j, k - 1];
                    arr[j, k - 1] = arr[j, k];
                    arr[j, k] = temp;
                }
                else
                {
                    temp = arr[j, k - 1];
                }
    temp = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)  // 3. запускаем (2) и (1) до победного
        for (int j = 1; j < arr.GetLength(1); j++)  // 2. перебираем столбцы
            for (int k = 0; k < arr.GetLength(0); k++) // 1. перебираем столбцы и больший эл. передвигаем вниз
                if (temp > arr[j, k])
                {
                    temp = arr[j - 1, k];
                    arr[j - 1, k] = arr[j, k];
                    arr[j, k] = temp;
                }
                else
                {
                    temp = arr[j - 1, k];
                }
    return arr;
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
FillArray(array);
PrintArray(array);
Console.WriteLine("отсортированный массив:");
SortArray(array);
PrintArray(array);

