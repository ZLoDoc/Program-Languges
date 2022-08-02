﻿// Задача 28: Напишите программу, которая принимает
//  на вход число N и выдаёт массив произведений чисел от 1 до N.
// 4 -> 1 2 6, 24
// 5 -> 1 2 6, 24 120
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
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int[] factor(int N)
{
    int[] myArray = new int[N];
    int F = 1;
    for (int i = 1; i <= N; i++)
    {
        F = F * i;
        myArray[i - 1] = F;
    }
    return myArray;
}
PrintArray(factor(N));

