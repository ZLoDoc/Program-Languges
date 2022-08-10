﻿// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// x=(b2-b1)/(k1-k2)
// y=k1*((b2-b1)/(k1-k2))+b1

double[] Intersection(double b1, double b2, double k1, double k2)
{
    double[] array = new double[2];

    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return array;

}

Console.Write("\nВведите значение B1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите значение K1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите значение B2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите значение K2:");
double k2 = Convert.ToInt32(Console.ReadLine());
double[] array = new double[2];
if (k1 != k2)
{
    array = Intersection(b1, b2, k1, k2);
    Console.Write($"\nТочка пересечения двух прямых А({array[0]},{array[1]})");
}
if (k1 == k2) Console.Write($"\nДанные прямые парраллельны");
