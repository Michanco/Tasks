// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два натуральных числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 1 || number2 < 1) Console.WriteLine("Одно из введённых чисел не натуральное");
else
{
    if (number1 > number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
        int sumNaturalNumbers = SumNaturalNumbers(number1, number2);
        Console.WriteLine($" M = {number2}; N = {number1} -> {sumNaturalNumbers}");
    }
    else
    {
        int sumNaturalNumbers = SumNaturalNumbers(number1, number2);
        Console.WriteLine($" M = {number1}; N = {number2} -> {sumNaturalNumbers}");
    }
}


int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else return num1 + SumNaturalNumbers(num1 + 1, num2);
}