// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] masterMatrix = NewMatrixRndInt(4,4,0,9);
if(TrueSquareMatrix(masterMatrix))
{
    PrintMatrix(masterMatrix);
    ChangeRowsColumns(masterMatrix);
    Console.WriteLine();
    PrintMatrix(masterMatrix);
}
else 
{
    PrintMatrix(masterMatrix);
    Console.WriteLine();
    Console.WriteLine("Замена строк на столбцы невозможна");
}

bool TrueSquareMatrix(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}

void ChangeRowsColumns(int[,] matrix)
{
    for (int  i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
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