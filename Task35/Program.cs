// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = NewArray(0, 200, 10);
PrintArray(array);
int countElements = CountElements(array);
Console.Write($" ->  {countElements}");


int CountElements(int[] arr, int min1 = 10, int max1 = 99)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] >= min1 &&  arr[i] <= max1) count ++;
    }
    return count;
}

int[] NewArray(int min1, int max1, int size)
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
    for (int i = 0; i < arr.Length -1; i++)
    {
       Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length -1] + " ]");
}
