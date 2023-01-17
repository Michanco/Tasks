// Задача 36: Задайте 
// одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = NewArrayRndInt(-10, 10, 6);
PrintArray(array);
int oddElementsOfArray = SumOddElementsOfArray(array);
Console.Write($" -> {oddElementsOfArray}");

int SumOddElementsOfArray(int[] arr)
{
    int sumOdd = arr[1];
    for (int i = 3; i < arr.Length ; i++) 
    {
        if (i % 2 != 0 ) sumOdd += arr[i];
    }
    return sumOdd;
}

int[] NewArrayRndInt(int min1, int max1, int size)
{

    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min1, max1 + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}