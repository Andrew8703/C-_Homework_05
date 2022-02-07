// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10, 99);
Console.WriteLine(a);
int b = a % 10;
int c = a / 10;
if (b > c)
{
    Console.WriteLine(b);
}
else
    Console.WriteLine(c);
