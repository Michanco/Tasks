// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = NewArrayRndDouble(-100, 100, 10);
PrintArrayDbl(array);
double minArr = MinElementOfDblArray(array);
double maxArr = MaxElementOfDblArray(array);
double diffMinMax = maxArr - minArr;
diffMinMax = Math.Round(diffMinMax, 1);
Console.Write($" -> {diffMinMax}");

double MaxElementOfDblArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElementOfDblArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] NewArrayRndDouble(int min1, int max1, int size)
{

    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max1 - min1) + min1;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDbl(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}