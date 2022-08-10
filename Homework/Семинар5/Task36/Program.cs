// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] RndArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i <= array.Length - 1; i++)

    {
        Console.Write($" {array[i]},");
    }
}
int Position(int[]array)
{
    int sum=0;
    for (int i=0;i<=array.Length-1;i++)
    {
        if (i%2!=0) sum+=array[i];
    }
    return sum;
}

Console.WriteLine("Задайте длинну масива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(number);
PrintArray(array);
int result= Position(array);
Console.WriteLine($"\nВ заданном массиве сумма элементов на нечетных позициях равна {result}");