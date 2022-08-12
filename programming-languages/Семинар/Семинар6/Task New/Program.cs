// C клавиатуры задается размерность двумерного массива,
// найти максимум и его индекс, найти минимум и его индекс,
//  найти среднее арифметическое

int[,] RndArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(10, 100);
        }
    }
    return array;
}
void MinMax(int[,] array)
{
    double min = array[0,0];
    double max = array[0,0];
    int minRows = 0;
    int maxRows = 0;
    int minColumns = 0;
    int maxColumns = 0;

    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (max < array[rows, columns])
            {
                max = array[rows, columns];
                maxRows = rows;
                maxColumns = columns;
            }
            if (min > array[rows, columns])
            {
                min = array[rows, columns];
                minRows = rows;
                minColumns = columns;
            }
        }
    }
    double middle = (min + max) / 2;
    Console.WriteLine($"Минимальное значение {min} находится в ячейке [{minRows},{minColumns}]");
    Console.WriteLine($"Максимальное значение {max} находится в ячейке [{maxRows},{maxColumns}]");
    Console.WriteLine($"Среднее арифметическое максимального {max} и минимального значения {min} = {middle}");
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
MinMax(array);

