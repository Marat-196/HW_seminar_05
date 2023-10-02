// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int min, int max, int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]:F2}, ");
        else Console.Write($"{array[i]:F2}");
    }
    Console.Write("]");
}

double MaxValueArray(double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

double MinValueArray(double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива: ");
int sizeValue = Convert.ToInt32(Console.ReadLine());

double[] res = CreateArray(minValue, maxValue, sizeValue);
PrintArray(res);

double minNumber = MinValueArray(res);
double maxNumber = MaxValueArray(res);
double differenceNumber = maxNumber - minNumber;

if (minNumber < 0 && maxNumber > 0)
{
    double interim = minNumber * -1;
    Console.Write($" -> {maxNumber:F2} + {interim:F2} = {differenceNumber:F2}");
}
if (minNumber > 0 && maxNumber > 0)
{
    Console.Write($" -> {maxNumber:F2} - {minNumber:F2} = {differenceNumber:F2}");
}
if (minNumber < 0 && maxNumber < 0)
{
    double interim = minNumber * -1; 
    Console.Write($" -> {maxNumber:F2} + {interim:F2} = {differenceNumber:F2}");
}