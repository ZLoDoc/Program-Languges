// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool CheckPolindrom(string text)
{
    bool result = true;
    int length=text.Length;
    for (int i = 0; i < (length / 2); i++)
    {
        if (text[i] == text[length -1- i]) result = true; //Console.WriteLine($"{i} и {length - i} совпадают ");
        else result=false;
      
    }
    return result;
}
Console.WriteLine("Напишите ряд символов");
string text = Console.ReadLine();
bool result = CheckPolindrom(text);
if(result==true) Console.WriteLine("Это полиндром");
else Console.WriteLine("Это не полтндром"); 
