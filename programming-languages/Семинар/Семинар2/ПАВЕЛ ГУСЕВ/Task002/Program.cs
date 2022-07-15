bool IsKratno(int num1, int num2)
{
    bool value;
    if (num1 % num2 == 0) value = true;
    else value = false;
    return value;
}
Console.Write("Imput first number :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number :");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = IsKratno(num1, num2);
Console.WriteLine(result);
