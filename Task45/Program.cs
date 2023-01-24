// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array1 = NewArrayRndInt(10, -3, 5);
int[] array2 = CopyArray(array1);
PrintArray(array1);
PrintArray(array2);

int[] CopyArray(int[] arr)

{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}

int[] NewArrayRndInt(int size, int min1, int max1)
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
    Console.WriteLine();
}