// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] masterMatrix = NewMatrixRndInt(7, 6, -10, 10);
PrintMatrix(masterMatrix);
Console.WriteLine();
RowDescendingSort(masterMatrix);
PrintMatrix(masterMatrix);

void RowDescendingSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int q = matrix.GetLength(1) - 1; q > 0; q--)
        {
            for (int j = 0; j < q; j++)
            {
                int temp = matrix[i, j];
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }

        }
    }
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