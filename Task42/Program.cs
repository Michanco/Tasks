// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = 48;
string result = NumberBinary(number);
Console.WriteLine($"{number} -> {result}");


string NumberBinary(int num)
{
    string binar = string.Empty;
    while (num > 0)
    {   
        binar = num % 2 + binar;
        num /= 2;
    }
    return binar;
}





