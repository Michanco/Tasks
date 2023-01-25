// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] masterMatrix = NewMatrixRndInt(4, 4, 0, 9);
PrintMatrix(masterMatrix);
Console.Write("Среднее арифметическое каждого столбца");
double[] columnsAverage = ColumnsAverage(masterMatrix);
PrintArray(columnsAverage);


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

double[] ColumnsAverage(int[,] matrix)
{
    double[] aver = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        aver[j] = sum / matrix.GetLength(0);
        aver[j] = Math.Round(aver[j], 2);
    }
    return aver;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i], 5};");
    }
    Console.Write($"{arr[arr.Length - 1], 5}.");
    Console.WriteLine();
}