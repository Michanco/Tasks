// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] masterMatrix1 = NewMatrixRndInt(2, 4, 0, 6);
int[,] masterMatrix2 = NewMatrixRndInt(4, 6, 0, 6);
PrintMatrix(masterMatrix1);
Console.WriteLine();
PrintMatrix(masterMatrix2);
if (TrueProductMatrix(masterMatrix1, masterMatrix2))
{
    int[,] masterResMatrix = ProductMatrix(masterMatrix1, masterMatrix2);
    Console.WriteLine();
    PrintMatrix(masterResMatrix);
}
else Console.WriteLine("Перемножение матриц невозможно");

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int q = 0; q < matrix2.GetLength(0); q++)
            {
                resMatrix[i, j] += matrix1[i, q] * matrix2[q, j];
            }

        }
    }
    return resMatrix;
}

bool TrueProductMatrix(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
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