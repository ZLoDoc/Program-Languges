// Задача 33: Задайте массив. Напишите программу,
//  которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] RndArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i <= a - 1; i++)
    {
        array[i] = new Random().Next(0, 5);
        Console.Write($" {array[i]},");
    }
    return array;
}
bool FindNumber(int[] array, int number)
{
    bool expection = false;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] == number) expection = true;
        //Console.WriteLine($"expection = {expection}");
        //break;
    }
    return expection;
}

Console.Write("Задайте число элементов массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число для поиска от 0 до 4 : ");
int findNumber = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(lenghtArray);
bool result = FindNumber(array, findNumber);
Console.WriteLine(" ");
if (result == true) Console.WriteLine($"В заданном массиве, число {findNumber} присутствует");
if(result==false) Console.WriteLine($"В заданном массиве, число {findNumber} отсутствует");