//  (необязательная) 
//  Напишите программу, которая создает массив
//  из введенных через запятую цифр и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Sum(string text)
{
    int length = text.Length;
    int[] array = new int[length / 2];
    char comma = ',';
    int j = 0;
    string result = String.Empty;

    for (int i = 0; i < length; i++)
    {
        if(length==1)
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


                                    Console.WriteLine($"array[j]={array[j]}");
    int[] resArr = new int[j+1];
                                    Console.WriteLine($"j={j}");
                                    Console.WriteLine($"resArr.Lenght={resArr.Length}");

    for (int k = 0; k <= j; k++)
    {
                                    Console.WriteLine($"k={k}");
        resArr[k] = array[k];
                                    //Console.WriteLine(resArr[j-1]);
    }
    return (resArr);
}



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write($" {array[i]}");
         if(i<array.Length-1) Console.Write(",");
    }
}
Console.Write("Введите ряд чисел через запятую :");
string? text = Console.ReadLine();
int[] result = Sum(text);
PrintArray(result);