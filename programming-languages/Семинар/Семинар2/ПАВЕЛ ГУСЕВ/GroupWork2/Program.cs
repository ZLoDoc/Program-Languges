bool IsKratno(int num)
{

    if (num % 7 == 0 && num % 23 == 0)
    {
        bool result = true;
        return result;
    }
    else
    {
        bool result = false;
        return result;
    }
}

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
bool result = IsKratno(number);
if (result == true)
{
Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23");
}
