// 1 вид методов - ничего не принимает ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор....");
// }
// Method1();

// 2 вид методов - ничего не возвращает, принимает какие-то параметры  

// void Method2(string msg)
// {
//     Console.WriteLine(msg);

// }
// Method2(msg: "Привет Вася !!!");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 4, msg: "Привет Вася !!!");

// 3 вид методов - что-то возвращает, ничего непринимает 

// int Method3()
// {
//     return DateTime.Now.Year;

// }
// int year = Method3();
// Console.Write(year);

// 4 вид методов - что-то принимает, что-то возвращает

string Method4(int count, string text)
{
    // int i = 0;
    string result = String.Empty;
    // while (i < count)
    for (int i = 0; i < count; i++)
    {
        result = result + text;
        // i++;
    }
    return result;
}
string res = Method4(10, " Вася");
Console.WriteLine(res);
