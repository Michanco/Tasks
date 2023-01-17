// Задача 34: 
// Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = NewArrayRndInt(100, 1000, 12);
PrintArray(array);
int honElementsOfArray = HonElementsOfArray(array);
Console.Write($" -> {honElementsOfArray}");

int HonElementsOfArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length ; i++) 
    {
        if (arr[i] % 2 == 0 ) count ++;
            }
    return count;
}

int[] NewArrayRndInt(int min1, int max1, int size)
{

    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min1, max1);
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