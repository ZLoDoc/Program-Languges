// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
void Treangle(int a, int b, int c)
{
    if (a > b + c || b > a + c || c > a + b) Console.WriteLine(" Такой треугольник существовать не может");
    else Console.WriteLine(" С такими длиннами сторон треугольник существовать может");
}


Console.WriteLine("Ведите длину стороны A :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите длину стороны B :");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите длину стороны C :");
int c = Convert.ToInt32(Console.ReadLine());
Treangle(a, b, c);