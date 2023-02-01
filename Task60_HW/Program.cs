// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] masterArray3D = NewArray3DInt2Digit(10, 5, 2);
if (True2Digit(masterArray3D))
Console.WriteLine("Для заполнения матрицы такого размера не хватило не повторяющихся двухзначных чисел");
else PrintArray3DIndexs(masterArray3D);

bool True2Digit(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                if (arr3D[i, j, k] > 99) goto ExitT;
            }
        }
    }
    return false;
ExitT: return true;
}

int[,,] NewArray3DInt2Digit(int rows, int columns, int pages)
{

    int[,,] matrix = new int[rows, columns, pages];
    int temp = -99;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = temp;
                temp = matrix[i, j, k] + rnd.Next(1, 3);
                if (temp > -10 && temp < 10) temp = 10;

            }
        }
    }
    return matrix;
}

void PrintArray3DIndexs(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k],5} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}