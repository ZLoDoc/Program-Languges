﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Числа от 1 до {N} : ");
for (int i = 1; i <= N; i++)
{
    int k = i % 2;
    if (k == 0)
    {
        Console.Write($"{i} ");
    }
}
Console.Write(" - четные");