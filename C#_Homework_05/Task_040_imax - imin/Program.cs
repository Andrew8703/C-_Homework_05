// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
double[] array = new double[5];


double[] FillArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
    return mass;
}
void PrintArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($" {mass[i]} ");
    // Console.Write($" {Math.Round(mass[i], 2)} ");
}
double[] MaxMinusMin(double[] mass)
{
    double iMax=mass[0];
    double iMin=mass[0];
    double difference;
    for (int i = 0; i < mass.Length; i++)
        if (iMax < mass[i])
        {
            iMax = mass[i];
        }
        else if (iMin > mass[i])
        {
            iMin = mass[i];
        }
    difference = iMax - iMin;
    Console.WriteLine($"iMax = {iMax}  \niMin = {iMin} \ndifference = {Math.Round(difference, 1)}");
    return mass;
}
FillArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
MaxMinusMin(array);
