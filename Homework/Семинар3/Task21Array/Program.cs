
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N мерном пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int[,] array, int n)
{
    double result = 0;
    //int diff = array[0, 0];
    int[] mass = new int[n];
    int temp0 = 0;
    int temp1 = 0;
    int sum = 0;
    for (int b = 0; b <= n - 1; b++)
    {
        for (int a = 1; a >= 0; a--)
        {
            if (a == 1)
            {
                temp1 = array[a, b];
            }
            if (a == 0)
            {
                temp0 = array[a, b];
            }
        }
        mass[b] = temp1 - temp0;
    }
    for (int count = 0; count <= n - 1; count++)
    {
        sum = sum + (mass[count] * mass[count]);
    }
    return result = Math.Sqrt(sum);
}
Console.Write("Введите размерность пространства в котором находятся точки A и B : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] coordinat = new int[2, n];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j <= n - 1; j++)
    {
        Console.Write($"Введите {j + 1} координату {i + 1} точки : ");
        coordinat[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
double result = Distance(coordinat, n);
Console.WriteLine($"Расстояние между точками A и B в {n}-мерном пространстве  {result}");

