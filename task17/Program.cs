



Console.WriteLine(" Введите координату точки по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите координату точки по Y");
int y = Convert.ToInt32(Console.ReadLine());

if ( x > 0 && y > 0 )
{
    Console.WriteLine("Точка находится в 1 кардинате");
}
else if ( x < 0 && y > 0)
{
    Console.WriteLine(" Точка находится во 2 координате");
}
else if ( x > 0 && y > 0 )
{
    Console.WriteLine(" точка находится в 3 координате");
}
else if ( x > 0 && y < 0)
{
    Console.WriteLine("  точка находится в 4 координате");
}
else 
{
    Console.WriteLine(" Невозможно определить ");
}