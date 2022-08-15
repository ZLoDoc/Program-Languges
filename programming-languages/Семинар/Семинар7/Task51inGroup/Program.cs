/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int SumD1 = 0;
int SumD2 = 0;
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");


        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matr[i, j] = new Random().Next(1, 10);

        }
    }
}

void FindSumD1D2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) SumD1 = SumD1 + matr[i, j];
            if (i + j == m - 1) SumD2 += matr[i, j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("SumD1= " + SumD1);
    Console.WriteLine("SumD2= " + SumD2);
    

}
try
{
    FillArray(array);
    PrintArray(array);
    FindSumD1D2(array);
}
catch
{
    Console.Write("Надо что бы n=m");
}



