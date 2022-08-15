// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] CreateRndArray(int numM, int numN)
{
    int[,] resultArray = new int[numM, numN];
    for (int rows = 0; rows < resultArray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < resultArray.GetLength(1); columns++)
        {
            resultArray[rows, columns] = new Random().Next(-9, 10);
        }
    }

    return resultArray;
}

void printArray(int[,]array)
{
for (int rows = 0; rows < array.GetLength(0); rows++)
{
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        Console.Write($"{array[rows, columns]} ");
    }
    Console.WriteLine();
}
}

Console.Write("Ведите M :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите N :");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRndArray(m, n);
printArray(array);

