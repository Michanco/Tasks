// 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число   ");
long numberA = Convert.ToInt64(Console.ReadLine());

long Div10(long num)
{
    num = num / 10;
    return (num);
}
long SecondDigit(long num2)
{
    num2 = num2 % 10;
    return (num2);
}
long numberAbs = Math.Abs(numberA);
if (numberAbs < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (numberAbs > 999)
    {
        numberAbs = Div10(numberAbs);
    }
    long secondDigit = SecondDigit(numberAbs);
    Console.WriteLine($"Третья цифра числа {numberA} ==> {secondDigit}");
}