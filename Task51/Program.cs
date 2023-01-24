// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] matrix = NewMatrixRndInt(7, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Сумма элементов главной диагонали: ");
int[] array = OutputSum(matrix);
PrintArray(array);
int equalIndexSum = EqualIndexSum(matrix);
Console.WriteLine(equalIndexSum);



int[] OutputSum(int[,] matrx)
{
    int diag = matrx.GetLength(0);
    if (diag > matrx.GetLength(1) ) diag = matrx.GetLength(1);
    int[] arr = new int[diag];
    for (int i = 0; i < diag; i++)
    {
        arr[i] = matrx[i,i];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " + ");
    }
    Console.Write(arr[arr.Length - 1] + " = ");
}

int EqualIndexSum(int[,] matrx)
{
    int siz = matrx.GetLength(0);
    if (siz > matrx.GetLength(1) ) siz = matrx.GetLength(1);
    int sum = 0;
    for (int i = 0; i < siz; i++)
    {
        sum += matrix[i, i];
    }
return sum;
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