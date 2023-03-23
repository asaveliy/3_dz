// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Write("Введите число: ");

double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введенное число: " + number);

double division = number / 2;
Console.WriteLine("Неокругленное деление введенного числа: " + division);

int division_check = Convert.ToInt32(division);
Console.WriteLine("Округленное деление введенного числа: " + division_check);

if (number > 0)
{
    int index = Convert.ToInt32(number);
    int index_div = index / 2;
    if (division == index_div)
    {
        if(division == division_check)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет (нечетное)");
        }
    }
    else
    {
        Console.WriteLine("нет (нецелое или положительное нечетное)");
    }
}
else
{
    Console.WriteLine("нет (неположительное)");
}

