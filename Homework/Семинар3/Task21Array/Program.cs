void Distance(int[,] array, int n)
{
    double result = 0;
    int diff = array[0, 0];
    int[] mass = new int[n];

    for (int b = 0; b <= n - 1; b++)
    {
        for (int a = 1; a < 2; a++)
        {
            diff = array[a, b] - diff;
            Console.WriteLine($"DIFF = {diff}");
            Console.WriteLine($"ARRAY 2 {a},{b} = {array[a, b]}");
            //double result = Math.Sqrt((x * x) + (y * y) + (z * z));

        }

    }
}
Console.WriteLine("Введите размерность пространства в котором находятся точки A и B : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] coordinat = new int[2, n];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j <= n - 1; j++)
    {
        Console.WriteLine($"Введите {j + 1} координату {i + 1} точки : ");
        coordinat[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}

// for (int a = 0; a < 2; a++)
// {
//     for (int b = 0; b <= n - 1; b++)
//     {
//         Console.WriteLine($"ARRAY {a},{b} = {coordinat[a, b]}");
//     }
// }
Distance(coordinat, n);

