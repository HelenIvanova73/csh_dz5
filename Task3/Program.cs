/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double ReadDouble(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double[] GenerateArray(int len, double minValue, double maxValue)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

double DifferenceMaxMin(double[] array, double min, double max)
{
    double maxItem = min;
    double minItem = max;
    foreach (float item in array)
    {
        if (item > maxItem)
        {
            maxItem = item;
        }
        if (item < minItem)
        {
            minItem = item;
        }
    }
    return Math.Round(maxItem - minItem, 2);
}

int len = ReadInt("Введите длину массива > ");

double min = ReadDouble("Введите минимальную границу диапазона -> ");
double max = ReadDouble("Введите максимальную границу диапазона -> ");

double[] array = GenerateArray(len, min, max);
PrintArray(array);
Console.WriteLine($"Разность между макмимальным и минимальным = {DifferenceMaxMin(array, min, max)}");