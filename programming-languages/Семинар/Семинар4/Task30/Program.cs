// Задача30. Принимаем число N и заполняем массив с N
//  элементами случайно нулями и еденицами

int[] create_mas(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

PrintArray(create_mas(x));
