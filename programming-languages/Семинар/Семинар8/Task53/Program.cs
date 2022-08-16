// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

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

int[,] ReverseArray(int[,] array)
{
    int temp = 0;
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        temp = array[0, columns];
        array[0, columns] = array[array.GetLength(0) - 1, columns];
        array[array.GetLength(0) - 1, columns] = temp;
    }
    return array;

}
Console.Write("Количество строк : ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(str, col));
PrintArray(array);
Console.WriteLine();
int[,] newArray = ReverseArray(array);
PrintArray(newArray);