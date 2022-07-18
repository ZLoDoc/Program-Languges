// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int i = 123;
// char[] arr = i.ToString().ToCharArray();
// Console.WriteLine(arr[1]);

void StringToArray(int num)
{

    char[] array = num.ToString().ToCharArray();
   for (int index=0; index <= array.Length-1; index++)
   {
               
               
               
                Console.Write($"{array[index]} ");
   }
}

StringToArray(34567);