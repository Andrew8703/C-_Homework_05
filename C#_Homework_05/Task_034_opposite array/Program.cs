// Задача 34: Написать программу для замены элементов массива на противоположные.
int[] array = new int[10];

int[] FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(-100, 100);
    return mass;
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($" {mass[i]} ");
}
int[] FilloppositeArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = mass[i]*(-1);
    return mass;
}
FillArray(array);
Console.Write("Оригинальный массив:                  [");
PrintArray(array);
Console.Write("]");
FilloppositeArray(array);
Console.WriteLine();
Console.Write("Массив с противоположными элементами: [");
PrintArray(array);
Console.Write("]");


