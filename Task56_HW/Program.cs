// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] masterMatrix = NewMatrixRndInt(4, 3, 0, 20);
PrintMatrix(masterMatrix);
int rowMinSum = RowMinSum(masterMatrix);
Console.WriteLine();
Console.WriteLine($"{rowMinSum + 1} строка");


int RowMinSum(int[,] matrix)
{
    //int[] minSum = new int[matrix.GetLength(0)];
    int minIndex = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];

        }
        if (i == 0) minSum = rowSum;
        else if (rowSum < minSum)
        {
            minSum = rowSum;
            minIndex = i;
        }
    }
    // int minIndex = 0;
    // int minNumber = minSum[0];
    // for (int i = 0; i < minSum.Length; i++)
    // {
    //     if (minSum[i] < minNumber)
    //     {
    //         minNumber = minSum[i];
    //         minIndex = i;
    //     }

    // }
    return minIndex;
}

int[,] NewMatrixRndInt(int rows, int columns, int min1, int max1)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min1, max1 + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($" {matrix[i, j],4} , ");
        }
        Console.Write($" {matrix[i, matrix.GetLength(1) - 1],4}  ] ");
        Console.WriteLine();
    }
}