// C клавиатуры задается размерность двумерного массива,
//  создать поэлементную копию массива


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
}
int[,] CopyArray(int[,] array)
{
    int[,] copyArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            copyArray[rows, columns] = array[rows, columns];
        }
    }
    return copyArray;
}
Console.Write("Количество строк : ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,]array=(RndArray(str, col));
PrintArray(array);
Console.WriteLine("Копия массива");
PrintArray(CopyArray(array));

