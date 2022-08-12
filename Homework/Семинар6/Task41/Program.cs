// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] Sum(string text)
{
    int length = text.Length;
    //Console.WriteLine(length / 2);
    int[] array = new int[length / 2 + 1];
    char comma = ',';
    int j = 0;
    string result = String.Empty;

    for (int i = 0; i < length; i++)
    {
        if (length == 0)
        {
            array[j] = Convert.ToInt32(result);
            break;
        }
        if (text[i] == comma)
        {
            array[j] = Convert.ToInt32(result);
            result = String.Empty;
            j++;
        }
        else if (text[i] != comma) result = result + text[i];
    }
    array[j] = Convert.ToInt32(result);
    int[] resArr = new int[j + 1];
    for (int k = 0; k <= j; k++)
    {
        resArr[k] = array[k];
    }
    return (resArr);
}

int PositiveNums(int[] array)
{
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;

}

Console.Write("Введите ряд чисел через запятую :");
string? text = Console.ReadLine();
if (text == "")
{
    Console.WriteLine("Вы не ввели ни одного числа: ");
}
else
{
int[] array = Sum(text);
int count = PositiveNums(array);
Console.WriteLine($" \nВ заданном массиве {count} чисел больше нуля.");
}