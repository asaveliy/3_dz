// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.


// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




int[] Array(int mer)
{
    Console.WriteLine("Введите по одной ТОЛЬКО ЦИФРОВЫЕ значения координат следующей точки. Следуйте инструкции:");
    Console.WriteLine();
    int[] arr = new int[mer];
    for (int i = 0; i < mer; i++)
    {
        Console.Write("Введите одну координату и нажмите [ENTER]");
        arr[i] = int.Parse(Console.ReadLine());
    }
    // Console.WriteLine(String.Join(", ", arr));
    return arr;
}


void Distance(int[] arr1, int[] arr2)
{
    double result = 0;
    double sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        result = (arr2[i] - arr1[i]) * (arr2[i] - arr1[i]);
        sum = Math.Pow(result + sum, 0.5);
    }
    Console.WriteLine(Math.Round(sum, 2));
}



Console.WriteLine("Скольки мерное пространство рассматриваем ? ");
int mer = int.Parse(Console.ReadLine());
int[] coordA = Array(mer);
Console.WriteLine();
Console.WriteLine("Координата I точки приняты.");
int[] coordB = Array(mer);
Console.WriteLine("Координата II точки приняты.");
Console.WriteLine();
Console.Write("Расстояние между точками: ");
Distance(coordA, coordB);








