/* Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечётных/чётных чисел. */
int[] array = new int[10];
int counteven = 0;
int countnoteven = 0;

int[] FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(100, 1000);
    return mass;
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($" {mass[i]} ");
}
int[] Countevennoteven(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)

        if (mass[i] % 2 == 0)
        {
            counteven = counteven + 1;
        }
        else
            countnoteven = countnoteven + 1;
    Console.WriteLine("\nЧетных элементов:    " + counteven);
    Console.WriteLine("Не четных элементов: " + countnoteven);
    return mass;
}
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Countevennoteven(array);
Console.WriteLine();





