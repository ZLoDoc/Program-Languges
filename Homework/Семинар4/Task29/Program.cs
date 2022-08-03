//  (необязательная) 
//  Напишите программу, которая создает массив
//  из введенных через запятую цифр и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Sum(string text)
{
    int length = text.Length;
    int[] array = new int[length];
    var arr = "text".Split(',');
    char comma = ',';
    char space = ' ';
    int j = 0;
    string result = String.Empty;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == comma || text[i] == space)
        {
            array[j] = Convert.ToInt32(result);
            result = String.Empty;
            j++;
        }
        else if (text[i] != comma && text[i] != space) result = result + text[i];
    }
    array[j] = Convert.ToInt32(result);
    return (array);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");
}
Console.Write("Введите ряд чисел через запятую :");
string? text = Console.ReadLine();
int[] result = Sum(text);
PrintArray(result);