// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] RndArray(int num)
{
    int[,] array = new int[num, num];
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
void FindMinSumStringArray(int[,] array)
{

    int[] sumArray = new int[array.GetLength(0)];
    for (int rows = 0; rows <= array.GetLength(0) - 1; rows++)
    {
        for (int columns = 0; columns <= array.GetLength(1) - 1; columns++)
        {
            sumArray[rows] += array[rows, columns];
        }
        Console.WriteLine($"Сумма {rows} строки = {sumArray[rows]}");
    }

    int min = sumArray[0];
    int minIndex = 0;
    for (int i = 0; i < sumArray.Length - 1; i++)
    {

        if (sumArray[i] <= min)
        {
            min = sumArray[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Минимальная сумма значений {min} находится в {minIndex} строке");
}
Console.Write("Задайте размер квадратного массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(num));
PrintArray(array);
Console.WriteLine();
FindMinSumStringArray(array);