// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(size);
PrintArray(array);
int positiveCount = PositiveCount(array);
Console.WriteLine($" -> {positiveCount}");

int PositiveCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] InputArray(int siz)
{
    int[] arr = new int[siz];
    for (int i = 0; i < siz; i++)
    {
        Console.WriteLine($" Число № {i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
        for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
}