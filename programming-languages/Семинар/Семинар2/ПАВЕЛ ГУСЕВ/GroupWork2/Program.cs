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
IsKratno(Console.WriteLine());
