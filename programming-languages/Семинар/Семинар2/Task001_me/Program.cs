// Определение максимального и минимального значения матрицы и их индексов
void RndMass(int[] Mass)
{
    int strange = Mass.Length;
    for (int index = 0; index < strange; index++)
    {
        Mass[index] = new Random().Next(1, 20);
        Console.Write($"{Mass[index]} ");
    }
}
void MinMax(int[] Mass, out int vMin, out int iMin, out int vMax, out int iMax)
{
    int strange = Mass.Length;
    int index = 0;
    int valueMin = Mass[index];
    int valueMax = Mass[index];
    int maxIndex = 0;
    int minIndex = 0;
    for (; index < strange; index++)
    {
        if (valueMax < Mass[index])
        {
            valueMax = Mass[index];
            maxIndex = index;
        }
        if (valueMin > Mass[index])
        {
            valueMin = Mass[index];
            minIndex = index;
        }
    }
    vMin = valueMin;
    vMax = valueMax;
    iMin = minIndex;
    iMax = maxIndex;
}

int[] Mass = new int[20];
RndMass(Mass);
MinMax(Mass, out int vMin, out int iMin, out int vMax, out int iMax);
Console.WriteLine(" ");
Console.WriteLine($"Минималиное значение {vMin} находится в ячейке с индексом {iMin} ");
Console.WriteLine($"Максимальное значение {vMax} находится в ячейке с индексом {iMax} ");