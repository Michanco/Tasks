// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число которое будем искать в массиве");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = NewArray(-10, 10, 10);
Console.Write($"{number}; массив ");
PrintArray (array);
Console.Write( GetNumInArray(array, number) ? " -> Да " : " -> Нет");

bool GetNumInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;    
    }
    return false;
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