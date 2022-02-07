//Программа проверяет пятизначное число на палиндромом.
int number = new Random().Next(10000, 99999);
String s = number.ToString();
Console.WriteLine("Число: " + number);
if (s[0] == s[4] && s[1] == s[3])
{
    Console.WriteLine("Число - палиндром");
}
else
    Console.WriteLine("Число - не палиндром");