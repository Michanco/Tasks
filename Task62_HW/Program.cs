// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] masterMatrix = new int[8, 5];
NewSpiralMatrix(masterMatrix);
PrintMatrix(masterMatrix);


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

void NewSpiralMatrix(int[,] matrix)
{
    int end = matrix.GetLength(0) * matrix.GetLength(1);
    int temp = 1;
    //for (int i = 0; i < matrix.GetLength(0) - i; i++)
    int i = 0;
    int d = 0;
    while (i < matrix.GetLength(0) - i && d < matrix.GetLength(1) - d)
    {
        for (int j = 0 + i; j < matrix.GetLength(1) - d; j++)
        {
            matrix[i, j] = temp;
            temp++;
            //if (temp > end) goto Exit;
        }
        for (int k = 1 + i; k < matrix.GetLength(0) - i; k++)
        {
            matrix[k, matrix.GetLength(1) - 1 - i] = temp;
            temp++;
            //if (temp > end) goto Exit;
        }
        for (int g = matrix.GetLength(1) - 1 - d; g > d; g--)
        {
            matrix[matrix.GetLength(0) - 2 - d, g] = temp;
            temp++;
            //if (temp > end) goto Exit;
        }
        for (int q = matrix.GetLength(0) - 2 - i; q > i; q--)
        {
            matrix[q, i] = temp;
            temp++;
            //if (temp > end) goto Exit;
        }
        i++;
        d++;
    }
    //Exit:;
}