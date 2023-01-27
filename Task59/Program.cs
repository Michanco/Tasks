// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] masterMatrix = NewMatrixRndInt(6, 4, 0, 30);
PrintMatrix(masterMatrix);
Console.WriteLine();
int[] indexMinEl = IndexMinElement(masterMatrix);
PrintArray(indexMinEl);
Console.WriteLine();
int[,] newMasterMatrix = DeleteRowColumn(masterMatrix, indexMinEl[0], indexMinEl[1]);
PrintMatrix(newMasterMatrix);

int[,] DeleteRowColumn(int[,] matrix, int delRow, int delColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == delRow) n++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j < delColumn) newMatrix[i, j] = matrix[n, j];
            else newMatrix[i , j] = matrix[n, j + 1];
        }
        n++;
    }
    return newMatrix;
}

/*int[,] DeleteRowColumn(int[,] matrix, int delRow, int delColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == delRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == delColumn) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}*/

int[] IndexMinElement(int[,] matrix)
{

    int min = matrix[0, 0];
    int indexMinRow = 0;
    int indexMinColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMinRow = i;
                indexMinColumn = j;
            }
        }

    }
    int[] arr = new int[] { indexMinRow, indexMinColumn, min };
    return arr;
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

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    Console.WriteLine();
}