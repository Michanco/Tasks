// 10: Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число   ");
int numberA = Convert.ToInt32(Console.ReadLine());
int SecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return (num);
}
int secondDigit = SecondDigit(numberA);
if (Math.Abs(numberA) < 1000 && Math.Abs(numberA) > 99)
    Console.WriteLine($" Вторая цифра числа {numberA} ==> {Math.Abs(secondDigit)}");
else
{
    Console.WriteLine("Число не трёхзначное");
}