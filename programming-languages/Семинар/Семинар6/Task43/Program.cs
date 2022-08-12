// Задача 42: Напишите программу, которая будет преобразовывать десятичное число
//  в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Задайте десятичное число :");
int num = Convert.ToInt32(Console.ReadLine());
string res = String.Empty;

while (num > 0)
{
    res = (num % 2) + res;
    num = num / 2;
}
Console.Write(res);



