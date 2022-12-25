// 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


//  Math.Sqrt(225); - Корень из 225
//  Math.Pow(2, 10); - 2 в степени 10
// double numD = 5.099873456;
// double numRound = Math.Round(numD, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);

Console.WriteLine("Введите координаты двух точек");
Console.Write("XA : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("XB : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB : ");
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xa, ya, xb, yb);
double distanceR = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками =  {distanceR}");

double Distance(int x1, int y1, int x2, int y2)
{
    int leg1 = x1 - x2;
    int leg2 = y1 - y2;
    double distance2 = Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
    return (distance2);
}