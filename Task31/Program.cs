// Задача 31: 
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int negativeElementSum = NegativeElementSum(array);
int positiveElementSum = PositiveElementSum(array);

Console.WriteLine($"Сумма положительных элементов массива равна {positiveElementSum}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {negativeElementSum}");

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write(arr[i] + ",");
        else Console.WriteLine(" ]");
    }

}

int PositiveElementSum(int[] arr)
{
    int posSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) posSum += arr[i];
    } 
    return posSum;
}

int NegativeElementSum(int[] arr)
{
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) negSum += arr[i];
    } 
    return negSum;
}
