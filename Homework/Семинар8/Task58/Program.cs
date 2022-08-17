// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] CreateRndArray1(int num1, int num2)
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
int[,] CreateRndArray2(int num1, int num2)
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

int[,]MultipleArray(int[,] array1,int[,]array2)
{
    int [,]multArray=new int[array1.GetLength(0),array1.GetLength(1)];
    for (int rows = 0; rows < multArray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < multArray.GetLength(1); columns++)
        {
            multArray[rows,columns]=array1[rows,columns]*array2[rows,columns];
        }
        
    }
    return multArray;
}

Console.Write("Количество строк :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов :");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array1 = CreateRndArray1(a, b);
int[,] array2 = CreateRndArray2(a, b);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine("Произведение двух массивов :");
PrintArray(MultipleArray(array1,array2));