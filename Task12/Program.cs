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

int Remainder(int num1, int num2)
{
    int res = num1 % num2;
    return (res);
}

if (numberA > numberB)
{
    int remain = Remainder(numberA, numberB);
    Console.WriteLine(remain == 0 ? "Кратно" : $"Не кратно, остаток {remain}");
    //if (remain == 0) Console.WriteLine("Кратно");
    //else Console.WriteLine($"Не кратно, остаток {remain}");

}
// ver1
//int remain = numberA % numberB;
//if (remain == 0) Console.WriteLine("Кратно");
//else Console.WriteLine($"Не кратно, остаток {remain}");

// ver2
// {
//     bool remain =  numberA % numberB == 0;                                   
//     if (remain) Console.WriteLine("Кратно");                                
//     else Console.WriteLine($"Не кратно, остаток {numberA % numberB}");     
// }


else Console.WriteLine("Ничего не получится");