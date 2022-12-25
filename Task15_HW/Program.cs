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
    Console.WriteLine(numberA == 6 || numberA == 7 ? "Выходной" : "Рабочий");
}
else
{
    Console.WriteLine("Вы ввели некорректные данные");
}