// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void PrintArray(int[] array)
{
for(int i=0;i<=array.Length-1;i++) Console.Write($"{array[i]} ");
}
int[] RndArray(int num)
{
int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1,11);
}
return array;
}
int []ReverseArray(int[]array)
{
    int []result=new int [array.Length];
for (int i = 0; i <= array.Length-1; i++)
{
result[i]=array[array.Length-1-i];
}
return result;
}
Console.Write("Задайте длинну массива :");
int num=Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(num);
PrintArray(array);
Console.WriteLine();
PrintArray(ReverseArray(array));