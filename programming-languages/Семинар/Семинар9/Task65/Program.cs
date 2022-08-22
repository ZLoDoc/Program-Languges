// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int[] Array(int m, int n)
{
    int[] array = new int[n - m + 1];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = i + m;
    }
    return array;
}
string NumberString(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + NumberString(a + 1, b);
    }
    else return String.Empty;
}



void PrintArray(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++) Console.Write($"{array[i]} ");
}
Console.Write("Введите число M = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = Array(n, m);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(NumberString(n, m));