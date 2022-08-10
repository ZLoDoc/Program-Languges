// Задача37. Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и.т.д. 
//  Результат запишем в другой массив. 
// [1 2 3 4 5] -->5 8 3
// [6 7 3 6]--> 36 21
int[] RndArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($" {array[i]},");
    }
    Console.WriteLine();
    return array;
}


int[] Multiple(int[] array)
{
    int[] result = new int[array.Length / 2 + 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] += array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) result[i] += array[array.Length / 2];
    
    return result;
}


Console.WriteLine("Задайте длинну массива :");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(arrayLenght);
int[] res = new int[array.Length / 2 + 1];

res = Multiple(array);







