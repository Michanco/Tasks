﻿// 9. Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.
// 
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 ==> {number}");



// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// else 


//Console.WriteLine($"Наибольшая цифра числа  {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа ==> {maxDigit}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
