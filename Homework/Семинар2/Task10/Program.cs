// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//Console.WriteLine((782%100)/10);
void NUM(int Numbers)
{
    if (Numbers < 100 || Numbers >999)
{
    Console.Write($"Введенное число {Numbers} не трехзначное");
}
else
{
    Console.Write($"Вторая цифра в вашем числе {Numbers} : ");
    Console.Write((Numbers % 100) / 10);
}
}

Console.Write($"Введите трехзначное число : ");
int Numbers = Convert.ToInt32(Console.ReadLine());

// int Numbers =new Random().Next(1, 1500);
NUM(Numbers);