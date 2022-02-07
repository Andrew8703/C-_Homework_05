// Дано число. Проверить кратно ли оно 7 и 23
int a = new Random().Next(1, 500);
Console.WriteLine(a);
//int b = 7;
//int c = 23;
if (a%7==0 && a%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
Console.WriteLine("Число не кратно 7 и 23");

