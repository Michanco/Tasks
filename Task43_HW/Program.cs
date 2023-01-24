// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  Координата Х точки пересечения x=(b2-b1)/(k1-k2)
//  Координата Y точки пересечения y=(k1*b2-k1*b1)/(k1-k2)+b1



Console.WriteLine("Введите значения k1, b1, k2 и b2 для уравнений прямых:");
Console.WriteLine("y1 = k1 * x + b1");
Console.WriteLine("y2 = k2 * x + b2");
Console.Write(" k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают ");
else if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые парралельны ");
else
{
    double xCrossCoordinate = XCrossCoordinate(k1, b1, k2, b2);
    xCrossCoordinate = Math.Round(xCrossCoordinate, 2);
    double yCrossCoordinate = YCrossCoordinate(k1, b1, k2, b2);
    yCrossCoordinate = Math.Round(yCrossCoordinate, 2);
    Console.WriteLine($" Прямые пересекаются в точке ( {xCrossCoordinate}; {yCrossCoordinate} )");
}

double XCrossCoordinate(double k10, double b10, double k20, double b20)
{
    double xCoord = (b20 - b10) / (k10 - k20);
    xCoord = Math.Round(xCoord, 2);
    return xCoord;
}

double YCrossCoordinate(double k10, double b10, double k20, double b20)
{
    double yCoord = (k1 * b2 - k1 * b1) / (k1 - k2) + b1;
    yCoord = Math.Round(yCoord, 2);
    return yCoord;
}
