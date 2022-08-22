// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int StringSumm(int num)
{
    if (num == 0) return (0);
    else return num %10 +StringSumm(num/10);
}
Console.WriteLine(StringSumm(456));