// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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
    Console.Write("Количество строк : ");
    int str = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов : ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] array = (RndArray(str, col));
    PrintArray(array);