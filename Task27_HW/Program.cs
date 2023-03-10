// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumDigit}");

int SumDigit(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    int dig = 0;

    while (num > 0) 
    {
        dig = num % 10;
        num /= 10;
        sum += dig;
    }   
    return sum;
}