// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
int length = str.Length;



int Summa(int sum, int length)
{
    for (int i = 0; i < length; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int sum = Summa(0, length);
Console.WriteLine(sum);



