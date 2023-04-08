// // Задача HARD SORT необязательная. Считается за три обязательных 
// // Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// // Отсортировать элементы по возрастанию слева направо и сверху вниз.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 10 3
// // После сортировки
// // 1 2 3 4
// // 5 7 9 10


// void FillArray(int[,] array)
// {
//     for (int zapuscols = 0; zapuscols < array.GetLength(0); zapuscols++)
//         for (int rows = 0; rows < array.GetLength(1); rows++)
//             array[zapuscols, rows] = new Random().Next(0, 10);
// }


// // tentativo # 4. da sola, sabato


// int[,] SortArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//         for (int x = i; x < arr.GetLength(0); x++)
//             for (int y = 0; y < arr.GetLength(1) - x - 1; y++)
//                 if (arr[x, y] > arr[x, y + 1])
//                 {
//                     int temp = arr[x, y];
//                     arr[x, y] = arr[x, y + 1];
//                     arr[x, y + 1] = temp;
//                 }
//     return arr;
// }




// // tentativo # 3. da sola, sabato

// // int[,] SortArray(int[,] arr)
// // {
// //     int temp = arr[0, 0];
// //     int x = 0;
// //     for (int y = 1; y < arr.GetLength(1); y++)
// //     {
// //         while (arr[x, y - 1] > arr[x, y])
// //         {
// //             for (int i = 0; i <= arr.GetLength(0); i++)
// //                 for (int j = 0; j <= arr.GetLength(1); j++)
// //                 {
// //                     temp = arr[i, j];
// //                     arr[i, j] = arr[i, j + 1];
// //                     arr[i, j + 1] = temp;
// //                 }
// //         }
// //     }
// //     return arr;
// // }


// // tentativo # 2 + Demian, venerdì


// // int[,] SortArray(int[,] arr)
// // {
// //     for (int zap = 0; zap < arr.GetLength(0); zap++)  // 3. повторно запускает (2) и следовательно (1) до победного 
// //         for (int rows = 0; rows < arr.GetLength(1); rows++) // 2. переключает строки и снова запускает (1)  
// //             for (int cols = rows + 1; cols < arr.GetLength(1); cols++) // 1. запускает проверку по строке 
// //                 if (arr[zap, cols] < arr[zap, rows])
// //                 {
// //                     int temp = arr[zap, cols];
// //                     arr[zap, cols] = arr[zap, rows];
// //                     arr[zap, rows] = temp;
// //                 }
// //     return arr;
// // }


// // for (int zap = 0; zap < arr.GetLength(1); zap++)
// //         for (int cols = 0; cols < arr.GetLength(0); cols++)
// //             for (int rows = cols + 1; rows < arr.GetLength(0); rows++)
// //                 if (arr[zap, rows] < arr[zap, cols])
// //                 {
// //                     int temp = arr[zap, rows];
// //                     arr[zap, rows] = arr[zap, cols];
// //                     arr[zap, cols] = temp;
// //                 }




// void PrintArray(int[,] array)
// {
//     for (int zapuscols = 0; zapuscols < array.GetLength(0); zapuscols++)
//     {
//         for (int rows = 0; rows < array.GetLength(1); rows++)
//             Console.Write($"{array[zapuscols, rows],3} \t");
//         Console.WriteLine();
//     }
// }




// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// Console.WriteLine("исходный массив:");
// FillArray(array);
// PrintArray(array);
// Console.WriteLine("отсортированный массив:");
// int[] countRows = new int[rows];
// int[] countCols = new int[cols];
// // SortArray(array);
// // PrintArray(array);





// void SortRows(int[] arr, int rows, int cols)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//             arr[j] = arr[i, j];
//         BubbleSort(row);
//         Insert(true, i, row, arr);
//     }
//     PrintArray(arr);
//     Console.WriteLine("Сортировка по столбцам: ");
//     int[] col = new int[rowCount];
//     for (int i = 0; i < colCount; i++)
//     {
//         for (int j = 0; j < rowCount; j++)
//             col[j] = arr[j, i];
//         BubbleSort(col);
//         Insert(false, i, col, arr);
//     }
//     PrintArray(arr);
// }
// public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
// {
//     for (int k = 0; k < source.Length; k++)
//     {
//         if (isRow)
//             dest[dim, k] = source[k];
//         else
//             dest[k, dim] = source[k];
//     }
// }
// public static int[,] GenerateArray(int t, int i)
// {
//     int[,] table = new int[t, i];
//     Random random = new Random();
//     for (int a = 0; a < t; a++)
//     {
//         for (int b = 0; b < i; b++)
//         {
//             table[a, b] = random.Next(0, 9);
//         }
//     }
//     return table;
// }
// public static void PrintArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             Console.Write(array[a, b] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// static void BubbleSort(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//         for (int j = 0; j < inArray.Length - i - 1; j++)
//         {
//             if (inArray[j] > inArray[j + 1])
//             {
//                 int temp = inArray[j];
//                 inArray[j] = inArray[j + 1];
//                 inArray[j + 1] = temp;
//             }
//         }
// }


