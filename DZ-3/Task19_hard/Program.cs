// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.


Console.WriteLine("Введите любое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int sum = 0;
int reminder = 0;


CheckPalyndrom(num, temp, sum, reminder);




void CheckPalyndrom(int num, int temp, int sum, int reminder)
{
    if (num > 0)
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
        Console.WriteLine("Это НЕ положительное число");
    }
}