// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int[] Array(int num)
{
    int count = 1;
    int[] array = new int[num];
    for (int i = 0; i <= num - 1; i++)
    {
        array[i] = count;
        count++;
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
Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Array(n);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(NumberString(1,n));


