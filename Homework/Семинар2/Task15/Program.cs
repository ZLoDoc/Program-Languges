// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void week(int Number)
{
    string message = " ";
    if (Number > 0 && Number < 6)
    {
        message = "Нет";
    }
    else if (Number > 5 && Number < 8)
    {
        message = "Да";
    }
    else if (Number < 0 || Number > 7)
    {
        message = "Число не соответствует дню недели";

    }
    Console.WriteLine($"{Number} день недели выходной ? - {message}");
}
Console.Write($"Введите число от 1 до 7 соответствующее дню недели : ");
int Number = Convert.ToInt32(Console.ReadLine());
week(Number);


