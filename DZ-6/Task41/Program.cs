// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 5
// 1, -7, 567, 89, 223-> 3



int[] FormArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число и нажмите [Enter]:");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}



int CountPos(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > 0) count += 1;
    }
    return count;
}



Console.WriteLine("Сколько цифр желаете ввести?");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
FormArray(array);
Console.WriteLine($"Введено {CountPos(array)} четных чисел.");


