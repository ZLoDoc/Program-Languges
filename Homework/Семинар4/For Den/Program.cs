string[] StringToArray(string? text)
{
    string[] arr = text.Split(',');
    return (arr);
}
void PrintArray(string[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

Console.Write("Введите ряд чисел через запятую :");
string? text = Console.ReadLine();
PrintArray(StringToArray(text));