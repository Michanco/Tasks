// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    Console.WriteLine(Palindrom(number) ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}

bool Palindrom(int num)
{
    return num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10 ;
}