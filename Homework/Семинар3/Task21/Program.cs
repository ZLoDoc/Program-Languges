// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double result = Math.Sqrt((x * x) + (y * y) + (z * z));
    return result;
}

Console.Write("Введите X1= ");
double a1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y1= ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Z1= ");
double c1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X2= ");
double a2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y2= ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Z2= ");
double c2 = Convert.ToDouble(Console.ReadLine());

double result = Dist(a1, b1, c1, a2, b2, c2);
Console.WriteLine(result);