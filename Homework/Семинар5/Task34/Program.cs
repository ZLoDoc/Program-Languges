// Задача 34: Задайте массив заполненный
//  случайными положительными трёхзначными числами.
//   Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] RndArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int Even(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}

Console.WriteLine("Задайте длинну масива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(number);
PrintArray(array);
int even = Even(array);
Console.WriteLine($"\n В заданном массиве {even} четных чисел");