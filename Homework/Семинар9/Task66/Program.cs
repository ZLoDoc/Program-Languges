// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNums (int m,int n)
{
    if(m<=n) return m+SumNums(m+1,n);
    else return 0;
}
int m = 4, n = 8;
Console.WriteLine($"M = {m}, N = {n}\n"+ SumNums(m, n));