// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число А  ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В  ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    int quot = numberA % numberB;
    if (quot == 0) Console.WriteLine("Кратно");
    else Console.WriteLine($"Не кратно, остаток {quot}");
}
else Console.WriteLine("Ничего не получится");