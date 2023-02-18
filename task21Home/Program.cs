// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double xa = ReadNumber(" Введите координату точку X по A");
double ya = ReadNumber(" Введите координату точку Y по A");
double ca = ReadNumber(" Введите координату точку C по A");
double xb = ReadNumber(" Введите координату точку X по B");
double yb = ReadNumber(" Введите координату точку Y по B");
double cb = ReadNumber(" Введите координату точку C по B");

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(cb - ca, 2));
Console.WriteLine(" Вывод : " + res);
