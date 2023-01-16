// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = NewArray(-10, 10, 4);
PrintArray (array);
int[] invArray = InversionArray(array);
Console.Write(" -> ");
PrintArray (invArray);

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

int[] InversionArray(int[]arr)
{
    for (int i  = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}





