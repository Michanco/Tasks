// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите три числа");

int digit1 = Convert.ToInt32(Console.ReadLine());
int digit2 = Convert.ToInt32(Console.ReadLine());
int digit3 = Convert.ToInt32(Console.ReadLine());

bool IsPositiveChecking(int num1, int num2, int num3)
{
    return num1 < 0 || num2 < 0 || num3 <0 ; 
}

bool IsExistTriangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1;
}
if (IsPositiveChecking(digit1, digit2, digit3)) Console.WriteLine("Некорректный ввод");
else 
{
    bool result = IsExistTriangle(digit1, digit2, digit3);
    Console.WriteLine( result ? "Может"  : "Не может");
}
