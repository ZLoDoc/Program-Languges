// Задача37. Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и.т.д. 
//  Результат запишем в другой массив. 
// [1 2 3 4 5] -->5 8 3
// [6 7 3 6]--> 36 21
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

Console.Write("Задайте длинну массива :");
int num=Convert.ToInt32(Console.ReadLine());
int[] array = RndArray(num);
PrintArray(array);

string result = String.Empty;

for (int i = 0; i < array.Length / 2; i++)
{
result += $"{array[i] * array[array.Length - i - 1]}, ";
}
if (array.Length % 2 != 0) result += $"{array[array.Length / 2]}";
Console.WriteLine($"\n{result}");