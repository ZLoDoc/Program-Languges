//  (необязательная) 
//  Напишите программу, которая создает массив
//  из введенных через запятую цифр и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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