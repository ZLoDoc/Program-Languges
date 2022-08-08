// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] RndArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i <= a - 1; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write($" {array[i]},");
    }
    return array;
}
int[] ConvertNumbers(int[] array)
{
    int[] resArr = new int[array.Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        resArr[i] = array[i] * -1;
        //Console.WriteLine($"i = {i}");
    }
    return resArr;
}

void PrintArray(int[] array)
{
    Console.WriteLine(" ");
    for (int i = 0; i <= array.Length - 1; i++)
    {
        //Console.WriteLine(" ");
        Console.Write($" {array[i]},");
    }
}

Console.Write("Задайте число элементов массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(lenghtArray);
int[] result = ConvertNumbers(array);
PrintArray(result);
