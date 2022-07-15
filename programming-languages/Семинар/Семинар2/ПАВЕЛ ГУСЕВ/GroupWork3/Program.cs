bool Square(int number1, int number2)
{
    int square1 = number1 * number1;
    int square2 = number2 * number2;
    bool result;
    if (square1 == number2)
    {
        result = true;
        return result;
    }
    if (square2 == number1)
    {
        result = true;
        return result;
    }
    else
    {
        result = false;
        return result;
    }
}

Console.WriteLine("Imput the first number :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput the second number :");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = Square(num1, num2);

if (result == true)
{
    Console.WriteLine($"Оne of the numbers is the square of the other number :");
}
else
{
    Console.WriteLine($"One of the numbers isт't the square of the other number :");
}