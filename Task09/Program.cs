// 9. Напишите программу, которая 
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
    int firstDigit = Math.Abs(number) / 10;
    int secondDigit = Math.Abs(number) % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

Console.Write("Теперь вы введите двухзначное число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ( Math.Abs(number1) > 9 && Math.Abs(number1) < 100 ) 
{
    int maxDigit1 = MaxDigit(number1);
    Console.WriteLine($"Наибольшая цифра числа ==> {maxDigit1}");
}    
else  Console.WriteLine("Ваше число не двухзначное");
    
