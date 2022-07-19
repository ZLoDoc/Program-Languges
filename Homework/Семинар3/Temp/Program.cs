// Int[] Spiral_Min(Int[,] arr)
// {
//     List<Int> list = new List<Int>();
//     Int n = arr.GetLength(0);
//     Int count = n;
//     Int value = -n;
//     Int sum = -1;
//     do
//     {
//         value = -1 * value / n;
//         for (Int i = 0; i < count; i++)
//         {
//             sum += value;
//             list.Add(arr[sum / n, sum % n]);
//         }
//         value *= n; count--;
//         for (Int i = 0; i < count; i++)
//         {
//             sum += value;
//             list.Add(arr[sum / n, sum % n]);
//         }
//     }
//     while (count > 0); return list.ToArray();
// }

void Snail(int num)
{
    int[,] array = new int[num, num];
    int count = 1;
    int x = 0;
    int y = 0;

    for (; x < num; x++) //1 Прохождение первой строки квадрата  ¯\_(ツ)_/¯
    {
        //array[x, y] = count;
        //Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x - 1, y = y + 1; y < num; y++)
    {
        //array[x, y] = count;
        //Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x - 1, y = y - 1; x >= 0; x--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }

    for (x = x + 1, y = y - 1; y >= 1; y--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x + 1, y = y + 1; x < num - 1; x++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x - 1, y = y + 2; y < num; y++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x - 2, y = y - 2; x >= 0; x--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x + 2, y = y - 2; y >= 2; y--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    for (x = x + 1, y = y + 1; x < num - 2; x++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
}
Snail(5);

