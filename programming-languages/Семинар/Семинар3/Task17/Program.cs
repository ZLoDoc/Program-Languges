// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Dekart(int x, int y)
{
    int result = -1;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Введите X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y = ");
int y = Convert.ToInt32(Console.ReadLine());
int result = Dekart(x, y);
Console.WriteLine($"Заданная точка находится в {result} четверти");