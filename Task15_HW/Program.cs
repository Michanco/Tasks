// 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 8 && numberA > 0)
{
    if (numberA == 6 || numberA == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("Вы ввели некорректные данные");
}