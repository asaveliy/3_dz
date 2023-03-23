// Задача 27 HARD: Напишите программу, которая принимает на вход 
// число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9,012 -> 12
// 6,02214129e23 -> 27




// РЕШЕНИЕ НЕДОСТАТОЧНОЕ: 
// ОСТАЛОСЬ НАЙТИ СПОСОБ УДАЛЯТЬ ЗАПЯТУЮ ИЗ МАССИВА, 
// ИЛИ СЧИТЫВАТЬ ТОЛЬКО ЦИФРЫ С ВВОДИМОГО МАССИВА






double ConvertNatur(double n, int length)
{
    for (int i = 0; i < length; i++)
    {
        n *= 10;
    }
    return n;
}



// string DelVirgola(string array, int length) 
// {
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] == array[i] / 1)
//         {
//             return array[i];
//         }
//         else i++;
//     }
//     return array;
// }



int Summa(double number)
{
    int sum = 0;
    int nn = Convert.ToInt32(number);
    while (nn > 0)
    {
        sum += nn % 10;
        nn /= 10;
    }
    return sum;
}




Console.WriteLine("Введите число - целое, вещественное, в экспоненциальной форме: ");
double num = Convert.ToDouble(Console.ReadLine());
string str = Convert.ToString(num);
int length = str.Length;
Console.WriteLine($"Сумма цифр в данном числе: {Summa(num)}");

// Console.WriteLine(str);
// Console.WriteLine(length);
// Console.WriteLine(naturNum);

