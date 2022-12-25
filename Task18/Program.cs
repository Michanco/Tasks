// 18: Напишите программу, которая 
// по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти системы координат  ");
string quarter = Console.ReadLine();
string coordinates = Сoordinates(quarter);
Console.WriteLine(coordinates);

string Сoordinates(string quarter2)
{
    if (quarter2 == "1") return " X > 0 , Y > 0";
    if (quarter2 == "2") return " X < 0 , Y > 0";
    if (quarter2 == "3") return " X < 0 , Y < 0";
    if (quarter2 == "4") return " X > 0 , Y < 0";
    return "Неверный ввод";
}

