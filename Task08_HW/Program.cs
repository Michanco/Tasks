// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1  ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = 2;

if (number <1 ) Console.WriteLine("Вы ввели число не больше 1");
else while (numberA <= number)
    {
        Console.Write($" {numberA}, ");
        numberA += 2;
    }
Console.WriteLine("Программа закончена");
