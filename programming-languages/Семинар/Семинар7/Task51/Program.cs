// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int[,] RndArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns]} ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}

int SumArray(int[,] array)
{
    int summ=0;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (rows  ==  columns ) summ +=array[rows, columns];
        }
    }
    return summ;
}

int ReversArray(int[,] array)
{
    int summ=0;
    for (int rows =0; rows > array.GetLength(0); rows++)
    {
        for (int columns = array.GetLength(1); columns > 0; columns--)
        {
            Console.WriteLine(array.GetLength(1)-1);
            if (rows  ==  columns ) summ +=array[rows, columns];
        }
    }
    return summ;
}

Console.Write("Задайте размер матрицы :");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(num, num));
PrintArray(array);
int result=SumArray(array);
int resultRevers=ReversArray(array);
Console.WriteLine(result);
Console.WriteLine(resultRevers);

