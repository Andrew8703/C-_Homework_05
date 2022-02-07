int x = new Random().Next(-99, 99);
Console.WriteLine(x);
int y = new Random().Next(-99, 99);
Console.WriteLine(y);

if (x ==0 || y ==0)
{
    Console.WriteLine("Одна из точек равна нулю");
}
else if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка в первой четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка во второй четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка в четвертой четверти четверти");
    }
    else Console.WriteLine("Точка в третьей четверти");