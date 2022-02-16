// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int[] array = new int[10];
int sum = 0;

int[] FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(0, 10);
    return mass;
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.ForegroundColor=ConsoleColor.Red;  
            Console.Write($" {mass[i]} ");
            Console.ResetColor();
        }
        else
        {
        Console.Write($" {mass[i]} ");
        }
    }    
}

int[] SumNotEvenPositions(int[] mass)
{
    for (int i = 1; i < mass.Length; i = i + 2)
        sum = sum + mass[i];
        Console.Write("\nСумма элементов стоящих на нечетных позициях массива: ");
        Console.ForegroundColor=ConsoleColor.Red; 
        Console.Write(sum);
        Console.ResetColor();
    return mass;
}
FillArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");
SumNotEvenPositions(array);





