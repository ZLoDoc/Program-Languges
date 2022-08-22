// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

static int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Accerman(m - 1, 1);
    if (m > 0 && n > 0) return Accerman(m - 1, Accerman(m, n - 1));
    return Accerman(m, n);
}
Console.WriteLine(Accerman(3, 2));