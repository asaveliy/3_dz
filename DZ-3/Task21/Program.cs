// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




Console.WriteLine("Введите координаты I точки по оси X:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты I точки по оси Y:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты I точки по оси Z:");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты II точки по оси X:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты II точки по оси Y:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты I точки по оси Z:");
int zb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DistancePount(xa, ya, za, xb, yb, zb));



double DistancePount(int xa, int ya, int za, int xb, int yb, int zb)
{
    double resultx = (xb - xa) * (xb - xa);
    double resulty = (yb - ya) * (yb - ya);
    double resultz= (zb - za) * (zb - za);
    double result = Math.Round(Math.Sqrt(resultx + resulty + resultz), 3); // как округлить? Math.Round...
    return result;
}

