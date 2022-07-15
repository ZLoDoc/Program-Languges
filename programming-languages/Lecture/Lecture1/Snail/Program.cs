Console.Clear();
//void PrintNum(index)

void Snail(int[,] Mass)
{
    int minX = 0;
    int minY = 0;
    int maxX = 0;
    int maxY = 0;
    int length=Mass.Length;
    Console.WriteLine(length);
    for (int index=0;index<Mass.Length;index++)
    {
    Console.WriteLine(index);

    }
    Console.WriteLine($"{minX}{minY}{maxX}{maxY}");
}
int mas = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[mas, mas];
Snail(Mass);

