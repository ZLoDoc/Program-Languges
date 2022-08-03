// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
int NumLenght(int num)
{
    int count = 0;
    if (num == 0) count = 1;
    while (num != 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return (count);
}
int Summ(int num, int lenght)
{
    int dlina = lenght;
    int summ = 0;
    int delitel = 10;
    int razriad = 1;
    for (int i = 1; i <= dlina; i++)
    {
        summ = summ + ((num % delitel) / razriad);
        delitel = delitel * 10;
        razriad = razriad * 10;
    }
    return (summ);
}
Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int lenght = NumLenght(num);
int summ = Summ(num, lenght);
Console.WriteLine($"Число {num}, {lenght}-значное");
Console.WriteLine($"Сумма всех чисел в числе - {summ}");