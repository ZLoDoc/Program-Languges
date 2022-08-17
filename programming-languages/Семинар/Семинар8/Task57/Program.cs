// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int[,] RndArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(0, 20);
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
void FindValue(int[,] array)
{
    // Находим максимальное значение массива
    int maxNum = array[0, 0];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (maxNum < array[rows, columns]) maxNum = array[rows, columns];
        }
    }
    //Формируем 1мерный массив размером равным максимальному значению 2мерного массива
    int[] countArray = new int[maxNum+1];
   //Накапливаем в 1мерном массиве под номером элемента равному значению исходного
   // 2мерного массива то сколько раз встречается это значение
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            countArray[array[rows, columns]]++;
        }
    }
    for (int i = 0; i <= countArray.Length - 1; i++)
    {
        // Выводим на консоль значения не пустых элементов
        if (countArray[i] != 0) Console.WriteLine($"Значение {i} встречается {countArray[i]} раз");
    }
}
Console.Write("Количество строк : ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = (RndArray(str, col));
PrintArray(array);
Console.WriteLine();
FindValue(array);