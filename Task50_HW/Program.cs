// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[] matrixSize = RandomMatrixSize(2, 10);
int[,] luckyMatrix = NewMatrixRndInt(matrixSize[0], matrixSize[1], 0, 9);
Console.WriteLine("Введите индексы элемента масссива от 1 до  10 ");
Console.Write(" № строки :");
int rowsLM = Convert.ToInt32(Console.ReadLine());
Console.Write(" № столбца :");
int columnsLM = Convert.ToInt32(Console.ReadLine());

if (rowsLM < 1 || columnsLM < 1) Console.WriteLine(" Индекс не может  быть меньше еденицы");
else if (TrueIndex(luckyMatrix, rowsLM, columnsLM))
{
    Console.WriteLine(" Элемента с таким индексом в массиве нет");
    PrintMatrix(luckyMatrix);
}
else
{
    Console.WriteLine($"Элемент с индексом ( {rowsLM}, {columnsLM} ) -> {luckyMatrix[rowsLM - 1, columnsLM - 1]}");
    PrintMatrixLuckyNumber(luckyMatrix, rowsLM, columnsLM);
}

void PrintMatrixLuckyNumber(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (i == rows - 1 && j == columns - 1) Console.Write($" **{matrix[i, j],3}**");
            else Console.Write($" {matrix[i, j],4} , ");
        }
        Console.Write($" {matrix[i, matrix.GetLength(1) - 1],4}  ] ");
        Console.WriteLine();
    }
}

bool TrueIndex(int[,] matrix, int rows, int columns)
{
    return rows > matrix.GetLength(0) || columns > matrix.GetLength(1);
}

int[] RandomMatrixSize(int min, int max)
{
    int[] siz = new int[2];
    Random rnd = new Random();
    for (int i = 0; i < 2; i++)
    {
        siz[i] = rnd.Next(min, max + 1);
    }
    return siz;
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