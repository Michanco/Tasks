// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"{sumDigit}");

int SumDigit(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumDigit(num / 10);

}