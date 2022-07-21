double Distance(int[,] array)
{
    double x = array[1, 0] - array[0, 0];
    double y = array[1, 1] - array[0, 1];
    double z = array[1, 2] - array[0, 2];
    double result = Math.Sqrt((x * x) + (y * y) + (z * z));
    return result;
}
int[,] coordinat = new int[2, 3];
for (int i = 0; i <= coordinat.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= coordinat.GetLength(1) - 1; j++)
    {
        if (i == 0)
        {
            Console.Write($"Введите {j + 1} координату первой точки : ");
            coordinat[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        if (i != 0)
        {
            Console.Write($"Введите {j + 1} координату второй точки : ");
            coordinat[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
Console.Write(" ");
double result = Distance(coordinat);
Console.WriteLine($"Расстояние между точками {result}");