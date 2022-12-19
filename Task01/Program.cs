// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите число А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());
int product = numberB * numberB;
if (product == numberA)
{
Console.WriteLine($"Ваше число А ({numberA}) равно квадрату числа B ({numberB})");  
}
else if (numberA == numberB)
{
  Console.WriteLine($"Ваше число А ({numberA}) равно числу B ({numberB})");   
}
else
{
   Console.WriteLine($"Ваше число А ({numberA}) не равно квадрату числа ({numberB})"); 
}