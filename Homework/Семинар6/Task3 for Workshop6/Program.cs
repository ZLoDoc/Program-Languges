// Напишите программу, на вход которой подаётся размерность матрицы и
// потом прямоугольная матрица в виде последовательности строк. .
// Программа должна вывести матрицу того же размера, у которой каждый
//  элемент в позиции i, j равен сумме элементов первой матрицы
//  на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1).
//  У крайних символов соседний элемент находится с противоположной стороны матрицы.
// В случае одной строки/столбца элемент сам себе является соседом 
// по соответствующему направлению.

// Sample Input 1:
// 3

// 9 5 3
// 0 7 -1
// -5 2 9

// Sample Output 1:
// 3 21 22
// 10 6 19
// 20 16 -1

// Sample Input 2:
// 1

// 1
// Sample Output 2:
// 4
int[,] CreatArray(int num)
{
    int[,] array = new int[num, num];
    for (int i=0;i<=num;i++)
    {
        Console.WriteLine($"Введите {i} строку: ");
        string Convert.ToIn
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i <= array.GetLength(0); i++)
    {
        for (int j = 0; j <= array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
        }

    }
}
//int[,] array = new int[3, 3] { { 9, 5, 3 }, { 0, 7, -1 }, { -5, 2, 9 } };
Console.Write("Введите размерность квадратной матрицы :");
int num = Convert.ToInt32(Console.ReadLine());

