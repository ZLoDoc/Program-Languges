Console.WriteLine("Напишите числом день недели от 1 до 7");
int week = Convert.ToInt32(Console.ReadLine());
if (week==1)
{
    Console.WriteLine("Понедельник");
}
if (week==2)
{
    Console.WriteLine("Вторник");
}
if(week==3)
{
    Console.WriteLine("Среда");
}
if (week==4)
{
    Console.WriteLine("Четверг");
}
if (week==5)
{
    Console.WriteLine("Пятница");
}
if (week==6)
{
    Console.WriteLine("Суббота");
}
if (week==7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Выбрано значение не лежащее в диапазоне от 1 до 7");
}