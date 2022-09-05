void PrintArray(string[] array)
{
    for (int i = 0; i <= array.Length - 1; i++) Console.WriteLine(array[i]);
    //Console.WriteLine($"array.Lenght={array.Length}");
}
string[] ResultArray(string[] array)
{
    string[] temporaryArray = new string[array.Length];
    int temporaryArrayIndex = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length == 3)
        {
            temporaryArray[temporaryArrayIndex] = array[i];
            temporaryArrayIndex++;
        }
    }
    string[] resultArray = new string[temporaryArrayIndex];
    for (int resultArrayindex = 0; resultArrayindex <= temporaryArrayIndex - 1; resultArrayindex++)
    {
        resultArray[resultArrayindex] = temporaryArray[resultArrayindex];
    }
    return (resultArray);
}
Console.Write("Сколько строк будете вводить? :");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
for (int i = 0; i <= num - 1; i++)
{
    Console.Write($"Введите {i + 1} набор символов :");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Среди введенных наборов символов :");
PrintArray(array);
string[] res = ResultArray(array);
if (res.Length!=0) Console.WriteLine("Присутствуют наборы из 3-х символов :");
else Console.WriteLine("Hаборы из 3-х символов отсутствуют");
PrintArray(res);