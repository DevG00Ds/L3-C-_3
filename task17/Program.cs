// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.



// Console.WriteLine(" Введите координату точки по Х");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" Введите координату точки по Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в 1 кардинате");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine(" Точка находится во 2 координате");
// }
// else if (x > 0 && y > 0)
// {
//     Console.WriteLine(" точка находится в 3 координате");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("точка находится в 4 координате");
// }
// else
// {
//     Console.WriteLine(" Невозможно определить ");
// }




int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x = ReadNumber("Введите координату точки по Х");
int y = ReadNumber("Введите координату точки по У");
// int xa = ReadNumber("Введите координату точки по Х");
// int ya = ReadNumber("Введите координату точки по У");
// int xb = ReadNumber("Введите координату точки по Х");
// int yb = ReadNumber("Введите координату точки по У");
Console.WriteLine(
    x > 0 && y > 0 ? "Точка находится в 1 кардинате" :
    x < 0 && y > 0 ? "Точка находится во 2 координате" :
    x > 0 && y > 0 ? "Точка находится в 3 координате" :
    x > 0 && y < 0 ? "точка находится в 4 координате" :
    " Невозможно определить "
);