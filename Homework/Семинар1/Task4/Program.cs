﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int max = 0;
Console.Write("Введите число a= ");
int a = Convert.ToInt32(Console.ReadLine());
max = a;
Console.Write("Введите число b= ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c= ");
int c = Convert.ToInt32(Console.ReadLine());
if (b > a && b > c) max = b;
if (c > a && c > b) max = c;
Console.WriteLine($"Из трех чисел {a} и {b} и {c} большее- {max}");