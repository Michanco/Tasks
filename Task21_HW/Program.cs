//  21. Напишите программу, которая 
//  принимает на вход координаты двух точек и 
//  находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53  


Console.WriteLine("Введите координаты двух точек в 3D пространстве");
Console.Write("XA : ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA : ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA : ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("XB : ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB : ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB : ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xa, ya, za, xb, yb, zb);
double distanceR = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками =  {distanceR}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int leg1 = x1 - x2;
    int leg2 = y1 - y2;
    int leg3 = z1 - z2;
    double distance2 = Math.Sqrt((leg1 * leg1) + (leg2 * leg2) + (leg3 * leg3));
    return distance2;
}