// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] RndArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i <= array.Length - 1; i++)
        array[i] = new Random().Next(1, 11);
        Console.WriteLine($"array{i}={array[i]},");
    return array;
}

// int[] Reverse(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i <= array.Length - 1; i++)
//     {
//         result[i] = array.Length - 1 - i;
//         Console.WriteLine(result[i]);
//         return result;
//     }
// }
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(num);
//int[] res = Reverse(array);
