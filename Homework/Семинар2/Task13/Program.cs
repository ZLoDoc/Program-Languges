// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void NUM(int Numbers)
{
    if (Numbers < 100)
{
    Console.Write($"В числе {Numbers} нет третьей цифры");
}
else if (Numbers >100 && Numbers <999)
{
    Console.Write($"Третья цифра в вашем числе {Numbers} : ");
    Console.Write(Numbers % 10);
}
if (Numbers >999 && Numbers <9999)
{
    Console.Write($"Третья цифра в вашем числе {Numbers} : ");
    Console.Write((Numbers % 100) / 10);
}
if (Numbers >9999 && Numbers <99999)
{
    Console.Write($"Третья цифра в вашем числе {Numbers} : ");
    Console.Write((Numbers % 1000) / 100);
}
}

Console.Write($"Введите целое число : ");
int Numbers = Convert.ToInt32(Console.ReadLine());
NUM(Numbers);