// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] masterMatrix = NewMatrixRndInt(5, 7, -15, 15);
PrintMatrix(masterMatrix);
Console.WriteLine();
int[] array = MatrixToArray(masterMatrix);
PrintArray(array);
Array.Sort(array);
PrintArray(array);
int[,] dictionary = Dictionary2(array);
PrintDictionary(dictionary);

int[,] Dictionary2(int[] arr)
{
    int numCount = 1;
    for (int i = 0; i < arr.Length -1 ; i++)
    {
        if (arr[i] != arr[i + 1]) numCount++;
    }
    int[,] matrix = new int[numCount, 2];
    int number = arr[0];
    int count = 1;
    int j = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            matrix[j, 0] = number;
            matrix[j, 1] = count;
            j++;
            count = 1;
            number = arr[i];
        }
    }
    matrix[j, 0] = number;
    matrix[j, 1] = count;
    return matrix;
}

/*void Dictionary(int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number} -> {count}");
}*/

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

void PrintDictionary(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            Console.Write($" {matrix[i, j],4} ->  ");
        }
        Console.Write($" {matrix[i, matrix.GetLength(1) - 1],4}");
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[index] = matrix[i, j];
            index++;
        }
    }
    return arr;
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