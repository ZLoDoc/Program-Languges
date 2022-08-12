// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] RndArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = rows + columns;
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

int[,] Array(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (rows % 2 == 0 && columns % 2 == 0) array[rows, columns] = array[rows, columns]*array[rows, columns];
        }
    }
    return array;
}

Console.Write("Количество строк : ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(str, col));
PrintArray(array);
int[,]result=(Array(array));
PrintArray(result);