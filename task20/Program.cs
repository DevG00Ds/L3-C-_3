﻿// Задача 20: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine(" Введите координату по оси Х первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(" Введите координату по оси У первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(" Введите координату по оси Х Второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(" Введите координату по оси У второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Console.WriteLine(c);


double ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double xa = ReadNumber(" Введите координату точку A по X");
double ya = ReadNumber(" Введите координату точку A по Y");
double xb = ReadNumber(" Введите координату точку B по X");
double yb = ReadNumber(" Введите координату точку B по X");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.WriteLine($"{res:f2}");