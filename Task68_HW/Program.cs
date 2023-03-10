// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM < 0 || numN < 0) Console.WriteLine("Одно из чисел отрицательное");
else
{
    int akkerman = Akkerman(numM, numN);
    Console.WriteLine($" m = {numM}, n = {numN} -> A(m, n) = {akkerman}");
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
