// Думаю как оптимизировать ¯\_(ツ)_/¯
Console.Clear();

void Snail(int num)
{
    // int[,] array = new int[num, num];
    // int count = 1;
    // int x = 0;
    // int y = 0;

    while (x < num)//1-5 Прохождение первой строки квадрата  
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        x++;
    }
    //6-9///////////////////////////////////////////////////////////////
    x = x - 1; y = y + 1;
    while (y < num)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        y++;
    }
    //9-13///////////////////////////////////////////////////////////////
    x = x - 1; y = y - 1;
    while (x >= 0)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        x--;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //13-16////////////////////////////////////////////////////////////////
    x = x + 1; y = y - 1;
    while (y >= 1)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.WriteLine($"{count,3}");
        count++;
        y--;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //16-19/////////////////////////////////////////////////////////
    x = x + 1; y = y + 1;
    while (x < num - 1)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        x++;
    }
    //19-21/////////////////////////////////////////////////////////
    x = x - 1; y = y + 1;
    while (y < num - 1)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        y++;
    }
    //21-23/////////////////////////////////////////////////////////
    x = x - 1; y = y - 1;
    while (x > 0)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        x--;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //23-24/////////////////////////////////////////////////////////
    x = x + 1; y = y - 1;
    while (y > 1)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        y--;
    }  
    //24-25/////////////////////////////////////////////////////////
x = x + 1; y = y + 1;
    while (x < num-2)
    {
        Console.SetCursorPosition(10 + x * 3, 6 + y);
        Console.Write($"{count,3}");
        count++;
        x++;
    }
     Console.WriteLine("");
    Console.WriteLine($"x={x}");
    Console.WriteLine($"y={y}");
    Console.WriteLine($"count={count}"); 
}
Snail(5);

