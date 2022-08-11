// Задача37. Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и.т.д. 
//  Результат запишем в другой массив. 
// [1 2 3 4 5] -->5 8 3
// [6 7 3 6]--> 36 21
int GetArrayLength(int[] array)
{
    if (array.Length % 2 != 0)
    {
        return array.Length / 2 + 1;
    }
    return array.Length / 2;
}

int[] RndArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(0,11);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++) Console.Write($" {array[i]}");
}

int[] Multiple(int[] array)
{
    int[] res = new int[GetArrayLength(array)];
    for (int i = 0; i <= array.Length / 2-1; i++)
    {
        res[i] = array[i] * array[array.Length - 1 - i];
        Console.WriteLine ($"array[{i}] = {array[i]}  array[{array.Length - 1 - i}]= {array[array.Length - 1 - i]}" );
    }
    if (array.Length % 2 != 0) res[res.Length - 1] = array[array.Length / 2];
    return res;
}

Console.WriteLine("Задайте длинну массива :");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int[]array=RndArray(arrayLenght);
PrintArray(array);
Console.WriteLine();
PrintArray(Multiple(array));








