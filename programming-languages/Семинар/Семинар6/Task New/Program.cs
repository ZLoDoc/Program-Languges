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
            array[rows, columns] = new Random().Next(0, 10);
        }
    }
    return array;
}
void MinMax(int [,]array)
{
    int min=0;
    int
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(0, 10);
        }
    }
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
int[,]array=(RndArray(str, col));
PrintArray(array);