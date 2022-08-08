// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int a, int b)
{
    int num = 1;
    for (int i = 1; i <= b; i++) num = num * a;
    return (num);
}

Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Degree(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result} ");


