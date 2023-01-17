// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = NewArray(1, 5, 8);
PrintArray(array);
int[] productArray = ProductPairsOfElementsArray(array);
Console.Write(" -> ");
PrintArray(productArray);

int[] ProductPairsOfElementsArray(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;   
    int[] arrRes = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length -1 - i)
        arrRes[i] = arr[i] * arr[(arr.Length-1) - i];
        else arrRes[i] = arr[i];
    }

    return arrRes;
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
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}