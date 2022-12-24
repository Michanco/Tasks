// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число   ");
int numberA = Convert.ToInt32(Console.ReadLine());

int Remainder(int num1, int num2)
{
    int res = num1 % num2;
    return (res);
}

int remainder1 = Remainder(numberA, 7);
int remainder2 = Remainder(numberA, 23);

Console.WriteLine(remainder1 == 0 && remainder2 == 0 ? "Кратно" : "Некратно");

