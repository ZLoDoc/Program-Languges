// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int[] Cube(int a)
{
    int[] array = new int[a];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = (index+1) * (index+1) * (index+1);
        //Console.WriteLine(array[index]);
    }
    return array;
}

Console.Write("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Cube(n);
foreach ( int index in array ) Console.Write($" {index}");

