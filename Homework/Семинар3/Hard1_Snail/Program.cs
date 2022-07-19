void Snail(int num)
{
    int[,] array = new int[num, num];
    int count = 1;
    int x = 0;
    int y = 0;

    for (; x < num; x++) //1 Прохождение первой строки квадрата
    {
        //array[x, y] = count;
        //Console.Write(array[x, y]);
        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //2///////////////////////////////////////////////////////////////
    //for (bigCount=0;bigCount<num-4;bigCount++)
    for (x = x - 1, y = y + 1; y < num; y++)
    {
        //array[x, y] = count;
        //Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //3////////////////////////////////////////////////////////////////
    for (x = x - 1, y = y - 1; x >= 0; x--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;

    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //4//////////////////////////////////////////////////////////////////////
    for (x = x + 1, y = y - 1; y >= 1; y--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //5////////////////////////////////////////////////////////////////
    for (x = x + 1, y = y + 1; x < num - 1; x++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //6///////////////////////////////////////////////////////////////
    for (x = x - 1, y = y + 2; y < num; y++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //7////////////////////////////////////////////////////////////////
    for (x = x - 2, y = y - 2; x >= 0; x--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //8//////////////////////////////////////////////////////////////////////
    for (x = x + 2, y = y - 2; y >= 2; y--)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
    //9////////////////////////////////////////////////////////////////
    for (x = x + 1, y = y + 1; x < num - 2; x++)
    {
        // array[x, y] = count;
        // Console.Write(array[x, y]);


        Console.SetCursorPosition(x, y);
        Console.WriteLine(count);
        count++;
    }
    // Console.WriteLine("");
    // Console.WriteLine($"x={x}");
    // Console.WriteLine($"y={y}");
    // Console.WriteLine($"count={count}");
}
Snail(5);
		