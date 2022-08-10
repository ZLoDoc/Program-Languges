// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int[] RndArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(0, 1000);
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

int MaxMin(int[] array)
{
    int max = array[1];
    int min = array[1];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"\nВ задвнном массиве наибольшее число :{max}");
    Console.WriteLine($"В задвнном массиве наименьшее число :{min}");
    return (max-min);
}

Console.Write("Задайте длинну масива :");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(number);
PrintArray(array);

int result = MaxMin(array);
Console.WriteLine($"В массиве разница между наибольшим и наименьшим значением равна {result}");