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
    for (int zapuscols = 0; zapuscols < array.GetLength(0); zapuscols++)
        for (int rows = 0; rows < array.GetLength(1); rows++)
            array[zapuscols, rows] = new Random().Next(0, 20);
}



int[,] SortArray(int[,] arr)
{
    int temp = arr[0, 0];
    int x = 0;
    for (int y = 1; y < arr.GetLength(1); y++)
    {
        while (arr[x, y - 1] > arr[x, y])
        {
            for (int i = 0; i <= arr.GetLength(0); i++)
                for (int j = 0; j <= arr.GetLength(1); j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
        }
    }
    return arr;
}


// int[,] SortArray(int[,] arr)
// {
//     for (int zap = 0; zap < arr.GetLength(0); zap++)  // 3. повторно запускает (2) и следовательно (1) до победного 
//         for (int rows = 0; rows < arr.GetLength(1); rows++) // 2. переключает строки и снова запускает (1)  
//             for (int cols = rows + 1; cols < arr.GetLength(1); cols++) // 1. запускает проверку по строке 
//                 if (arr[zap, cols] < arr[zap, rows])
//                 {
//                     int temp = arr[zap, cols];
//                     arr[zap, cols] = arr[zap, rows];
//                     arr[zap, rows] = temp;
//                 }
//     return arr;
// }


// for (int zap = 0; zap < arr.GetLength(1); zap++)
//         for (int cols = 0; cols < arr.GetLength(0); cols++)
//             for (int rows = cols + 1; rows < arr.GetLength(0); rows++)
//                 if (arr[zap, rows] < arr[zap, cols])
//                 {
//                     int temp = arr[zap, rows];
//                     arr[zap, rows] = arr[zap, cols];
//                     arr[zap, cols] = temp;
//                 }




void PrintArray(int[,] array)
{
    for (int zapuscols = 0; zapuscols < array.GetLength(0); zapuscols++)
    {
        for (int rows = 0; rows < array.GetLength(1); rows++)
            Console.Write($"{array[zapuscols, rows],3} \t");
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

