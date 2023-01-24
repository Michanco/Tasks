// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] matrix = NewMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
matrix = PositiveIndexSquare(matrix);
PrintMatrix(matrix);

int[,] PositiveIndexSquare(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrx.GetLength(1); j += 2)
        {
             matrx[i, j] *= matrx[i, j];
        }
    }
    return matrx;
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