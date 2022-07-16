// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
void Decart(int Quart, out int x, out int y)
{
    int a = 0;
    int b = 0;
    if (Quart == 1)
    {
        a = 1;
        b = 1;
    }
    if (Quart == 2)
    {
        a = -1;
        b = 1;
    }
    if (Quart == 3)
    {
        a = -1;
        b = -1;
    }
    if (Quart == 4)
    {
        a = 1;
        b = -1;
    }

    x = a;
    y = b;
}

Console.Write("Imput the number of quarter :");
int number = Convert.ToInt32(Console.ReadLine());

Decart(number, out int x, out int y);

if (x==1&&y==1) Console.WriteLine("Диапазон значений по X от 0 до +бесконечности, по Y от 0 до +бесконечности");
if (x==-1&&y==1) Console.WriteLine("Диапазон значений по X от 0 до -бесконечности, по Y от 0 до +бесконечности");
if (x==-1&&y==-1) Console.WriteLine("Диапазон значений по X от 0 до -бесконечности, по Y от 0 до -бесконечности");
if (x==1&&y==-1) Console.WriteLine("Диапазон значений по X от 0 до +бесконечности, по Y от 0 до -бесконечности");
