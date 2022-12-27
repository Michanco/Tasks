//  23. Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number > 0 && number % 1 == 0) TableCube(number);
else Console.WriteLine("Введено некорректое число");

void TableCube(double num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} || {Math.Pow(count, 3),6}");
        count++;
    }
}