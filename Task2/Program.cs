/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write($"{array[i]}\t"); 
    }
    System.Console.WriteLine();
}

int OddIndexSumm(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int len = ReadInt("Введите размерность массива -> ");
int min = ReadInt("Введите минимальную границу диапазона -> ");
int max = ReadInt("Введите максимальную границу диапазона -> ");
int [] array = GenerateArray(len, min, max);
ShowArray(array);


System.Console.WriteLine($"Сумма элементов с нечетными индексами = {OddIndexSumm(array)}");   