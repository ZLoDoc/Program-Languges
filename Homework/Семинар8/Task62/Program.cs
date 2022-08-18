// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];
const int n = 4;
const int m = 4;
// int[,] matrix = new int[n, m];

int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;

for (int i = 0; i < array.Length; i++)
{
    array[row, col] = i + 1;
    if (--visits == 0)
    {
        visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }

    col += dx;
    row += dy;
}

for (int rows = 0; rows < array.GetLength(0); rows++)
{
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        Console.Write(array[rows, columns]);
    }
    Console.WriteLine();
}