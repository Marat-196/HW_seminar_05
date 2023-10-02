// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumNumbersUnevenPosition(int[] arr)
{
    int sumCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumCount += arr[i];
        }
    }
    return sumCount;
}

Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива: ");
int sizeValue = Convert.ToInt32(Console.ReadLine());

int[] res = CreateArray(minValue, maxValue, sizeValue);
PrintArray(res);

int sumNumbersUnevenPosition = SumNumbersUnevenPosition(res);
Console.Write($" -> {sumNumbersUnevenPosition}");