// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int exponent = Exponent(number, degree);
    Console.WriteLine($" Число {number} в степени {degree} равно {exponent}");
}
else Console.WriteLine($" Число {degree} не натуральное ");

int Exponent(int num, int deg)
{
    int num1 = 1;
    for (int i = 1; i <= deg; i++)
    {
        checked
        {
            num1 *= num;
        }
    }
    return num1;
}


