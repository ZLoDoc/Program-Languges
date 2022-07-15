//Принимает трехзначное число убирает вторую цифру и возвращает двузначное

int ConvertNumber(int num)
{
    int first = (num / 100);
    int second = (num % 10);
    int result = ((first) * 10) + second;
    return result;
}

Console.WriteLine("Введите трехзначное число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Число не трехзначное !");
}
else
{
    int result = ConvertNumber(number);
    Console.WriteLine($"Если убрать вторую цифру , то получится: {result}");
}