// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double DistanceNumber(double x1, double y1, double z1, double x2, double y2, double z2) 
{    
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
}

Console.WriteLine("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2: ");
double zb = Convert.ToDouble(Console.ReadLine());

double Res = DistanceNumber(xa, ya, za, xb, yb, zb);

Console.WriteLine(Res);    
  
