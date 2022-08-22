// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
string StringNum(int m, int n)
{
    if (m <= n) return $" {m}, " + StringNum(m + 1, n);
    else return String.Empty;
}
int m = 4, n = 8;
Console.WriteLine($"M = {m}, N = {n}\n"+ StringNum(m, n));


