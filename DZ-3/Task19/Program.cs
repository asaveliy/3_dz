// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да







Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int sum = 0;
int reminder = 0;
CheckPalyndrom(num, temp, sum, reminder);




void CheckPalyndrom(int num, int temp, int sum, int reminder)
{
    if (num > 10000 & num < 99999)
    {
        while (num > 0)
        {
            reminder = num % 10;
            sum = (sum * 10) + reminder;
            num = num / 10;
        }
        if (temp == sum)
        {
            Console.WriteLine("Это Палиндром");
        }
        else
        {
            Console.WriteLine("Это НЕ палидром");
        }
    }
    else
    {
        Console.WriteLine("Это НЕ пятизначное число");
    }
}

