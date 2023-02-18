// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine(" Введите Число");
int N = Convert.ToInt32(Console.ReadLine());
int a = N % 10;
int b = N / 10 % 10;
int c = N / 1000 % 10;
int d = N / 10000 % 10;
int Num = N / 10000;

if (Num < 1 || Num > 9 )
{
    Console.WriteLine(N + " нет 5 цифр или колво цифр больше 5");
}
    else if ( d == a && c == b)
    {
    Console.WriteLine(N + " ПОЛИДРОМ");
    }
else
{
    Console.WriteLine(N + " Не ПОЛИДРОМ");
}


