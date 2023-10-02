// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int min, int max, int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EnevNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }

    }
    return count;
}

Console.Write("Введите минимальное трехзначное значение диапазона: ");
int minValue = Convert.ToInt32(Console.ReadLine());
if (minValue < 100)
{
    Console.WriteLine("Некорректное значение!");
    return;
}

Console.Write("Введите максимальное трехзначное значение диапазона: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
if (maxValue > 999)
{
    Console.WriteLine("Некорректное значение!");
    return;
}

Console.Write("Введите количество элементов массива: ");
int sizeValue = Convert.ToInt32(Console.ReadLine());

int[] res = GenerateArray(minValue, maxValue, sizeValue);
PrintArray(res);
int resCount = EnevNumbers(res);
Console.Write($" -> {resCount}");
