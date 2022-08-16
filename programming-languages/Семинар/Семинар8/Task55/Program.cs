// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это 
// невозможно, программа должна вывести 
// сообщение для пользователя.

int[,] RndArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(-100, 101);
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
int[,] TransponArray(int[,] array)
{
    int[,] turnArary = new int[array.GetLength(1), array.GetLength(0)];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            turnArary[columns, rows] = array[rows, columns];
        }
    }
    return turnArary;
}

Console.Write("Количество строк : ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(str, col));
PrintArray(array);
Console.WriteLine();
int[,] newArray = TransponArray(array);
PrintArray(newArray);