﻿// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.WriteLine(" Введите Число");
// int N = Convert.ToInt32(Console.ReadLine());

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber(" Введите число");

for ( int i = 1; i <=N; i++)
{
    Console.Write(i * i + ", ");
}
Console.WriteLine(N*N + ".");
