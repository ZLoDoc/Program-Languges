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


int[] Chet(int[] array)
{
    int[] chet = new int[array.Length / 2];
    for (int i = 0; i <= array.Length / 2 - 1; i++)
    {
        chet[i] = array[i] * array[array.Length - i - 1];
    }
    return chet;
}
// int[] nechet(int[] array)
// {
//     int[] chet = new int[array.Length / 2];
//     for (int i = 0; i <= array.Length / 2 ; i++)
//     {
//         chet[i] = array[i] * array[array.Length - i - 1];
//     }
//     chet[array.Length - 1] = array[array.Lenght / 2] + 1;
//     return chet;

Console.WriteLine("Задайте длинну массива :");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(arrayLenght);
int lenght = array.Length;
if (lenght % 2 == 0)
    int[] multiple = Chet(array);

else if (lenght % 2 != 0)
    int[] multiple = Nechet(array);
   
    
    




Console.WriteLine(" ");
for (int i = 0; i <= result.Length - 1; i++) Console.Write($" {multiple[i]},");