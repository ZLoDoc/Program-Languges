// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
int[,] OrderArray(int[,] array)
{
    int temp = 0;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[rows, j] > array[rows, j + 1])
                {
                    temp = array[rows, j + 1];
                    array[rows, j + 1] = array[rows, j];
                    array[rows, j] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Количество строк :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов :");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRndArray(a, b);
PrintArray(array);
Console.WriteLine();
PrintArray(OrderArray(array));