// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] RndArray(int a)
{
    int[] array = new int[a];
    //int i = new Random().Next(-9, 10);
    for (int i = 0; i <= a - 1; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]}, ");
    }
    return array;
}
void SumNumbers(int[] array, out int pos, out int neg)
{
    pos = 0;
    neg = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] > 0) pos = pos + array[i];
        if (array[i] <= 0) neg = neg + array[i];
    }
}
Console.Write("Задайте число элементов массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(lenghtArray);
int posetive;
int negative;
SumNumbers(array, out posetive, out negative);
Console.WriteLine($" ");
Console.WriteLine($"Сумма положительных чисел массива {posetive}");
Console.WriteLine($"Сумма отрицательных чисел массива {negative}");