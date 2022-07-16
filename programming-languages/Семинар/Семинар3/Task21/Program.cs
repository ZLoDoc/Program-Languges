// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Dist(int x1, int y1, int x2, int y2)
{
    double result = 0;
    int x = x1 - x2;
    int y = y1 - y2;
    result = Math.Sqrt(x*x+y*y);
        return result;
}
double num = 0;
Console.Write("X1= ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Y1= ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("X2= ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.Write("Y2= ");
int b1=Convert.ToInt32(Console.ReadLine());
num = Dist(a, b, a1, b1);
Console.Write($"Расстояние от точки А({a},{b}) до точки B ({a1},{b1}) равно {num}");

