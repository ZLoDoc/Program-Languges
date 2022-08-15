// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента либо значение элемента в двумерном массиве, 
// и возвращает значение либо индекс этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

int[,] CreateRndArray(int num1, int num2)
{
    int[,] array = new int[num1, num2];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
int[] StringToArray(string text)
{
    int length = text.Length;
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
void FindValue(int[,] array, int[] value)
{
    int count = 0;
    if (value.Length == 1)
    {
        int findValue = -1;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int columns = 0; columns < array.GetLength(1); columns++)
            {
                if (value[0] == array[rows, columns])
                {
                    Console.WriteLine($"Искомое значение {value[0]} находится в ячейке [{rows},{columns}]");
                    count++;
                }
            }
        }
        if (count == 0) Console.WriteLine($"Искомое значение {value[0]} осутствует в этом массиве");

    }
    if (value.Length == 2)
    {
        Console.WriteLine($"В ячейке [{value[0]},{value[1]}] находится значение {array[value[0], value[1]]} ");
    }
}


Console.Write("Количество строк :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов :");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRndArray(a, b);
PrintArray(array);
Console.Write("Введите значение для поиска или индекс ячейки через запятую :");
string text = Console.ReadLine();
int[] imputValue = StringToArray(text);

if (imputValue.Length == 2)
{
    if (imputValue[0] > array.GetLength(0) - 1 || imputValue[1] > array.GetLength(1) - 1)
        Console.WriteLine($"Элемент [{text}] отсутствует");
    else FindValue(array, imputValue);
}
if (imputValue.Length == 1) FindValue(array, imputValue);

