// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int[] SquareTable(int num)
{

    int[] square = new int[num];
    for (int index = 0; index <= num - 1; index++)
    {
        square[index] = index * index;
    }
    return square;
}

Console.Write("Imput N :");
int number = Convert.ToInt32(Console.ReadLine());
var squareMass = SquareTable(number + 1);
// for (int index = 0; index < squareMass.Length - 1; index++)
// {
//     Console.Write($"{squareMass[index]} ");
// }
foreach(int indexValue in squareMass)
{
     Console.Write($"{indexValue}  ");
}