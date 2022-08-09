// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreatArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i <= array.Length-1; i++)
    {
        array[i] = new Random().Next(0, 124);
        Console.Write($" {array[i]},");
    }
    return array;
}

int FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (array[i] > 10 && array[i] < 99) count++;
        
    }
    return count;
}
int result=0;
Console.WriteLine($"Задайте длину массива");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArray(lenghtArray);
Console.WriteLine(" ");
// Console.WriteLine("Какое число необходими найти");
// int findNumber = Convert.ToInt32(Console.ReadLine());
result = FindNumber(array);
Console.WriteLine($"Искомое значение встречается {result} раз");
