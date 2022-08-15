// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRndArray(int num1, int num2)
{
    int[,] array = new int[num1, num2];
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
}
void SumOfColumns(int[,] array)
{
    double midleArithmetic = 0;

    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        double sumColumns = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sumColumns += array[rows, columns];
            // Console.Write($"{sumColumns},{columns},{rows}|");
        }

        midleArithmetic = sumColumns / array.GetLength(0);
        Console.Write("{0:0.00}; ", midleArithmetic);
        sumColumns = 0;
    }
}

Console.Write("Количество строк :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов :");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRndArray(a, b);
PrintArray(array);
Console.WriteLine();
SumOfColumns(array);