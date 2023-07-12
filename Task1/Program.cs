/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int EvenCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int len = ReadInt("Введите количество элементов массива ->");
int[] array = GenerateArray(len);
ShowArray(array);
System.Console.WriteLine($"{EvenCount(array)} чётных элементов в массиве");