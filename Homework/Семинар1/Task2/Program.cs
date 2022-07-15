// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int max = 0;
Console.Write("Введите число a= ");
int a = Convert.ToInt32(Console.ReadLine());
max = a;
Console.Write("Введите число b= ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a) max = b;
Console.WriteLine($"Из двух чисел {a} и {b} большее- {max}");
