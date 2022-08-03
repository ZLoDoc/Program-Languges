//  (необязательная) 
//  Напишите программу, которая создает массив
//  из введенных через запятую цифр и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Чтение строки 
// запись строки в массив
// вывод массива на экран


int[] Sum(string text)
{
    int length = text.Length;
    int[] array = new int[length];
    char comma = ',';
    char space = ' ';
    int j = 0;
    string result = String.Empty;
    
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"j={j}");
        Console.WriteLine($"i={i}");
       
        if (text[i] == comma || text[i] == space)
        {
            array[j] = Convert.ToInt32(result);
            Console.WriteLine($"Накопительный {array[j]}");
            result = String.Empty;

            j++;
        }
        else if (i == length)
        {
            array[j] = Convert.ToInt32(result);
            Console.WriteLine($"последний result  {array[j]}");
            result = String.Empty;
            ;
        }
        else if (text[i] != comma && text[i] != space) result = result + text[i];
        Console.WriteLine($"result после {i} прохода - {result}");
        Console.WriteLine($"сейчас идет {i} проход, длинна -{length}");
    }
    return (array);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");
}
Console.WriteLine("Введите ряд чисел через запятую");
string? text = Console.ReadLine();
int[] result = Sum(text);
PrintArray(result);
Console.WriteLine(result);