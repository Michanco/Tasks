// 19_2. Напишите программу, которая 
// принимает на вход  число и 
// проверяет, является ли оно палиндромом.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите целое положительное число");
long number = Convert.ToInt64(Console.ReadLine());

Console.WriteLine(NumberRevers(number) == number ? "Да" : "Нет");

long NumberRevers(long num)
{
    long numberRevers = 0;
    while (num > 0)
    {
        long lastDigit = num % 10;
        num = num / 10;
        numberRevers = numberRevers * 10 + lastDigit;
    }
    return numberRevers;
}