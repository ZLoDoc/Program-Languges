// //////////////////////////////////////////////////////////////////////////////
// Собрать строку с числами от А до B
//Вариант1
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
//Вариант2
string NumbersRec1(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + NumbersRec1(a + 1, b);
    }
    else return String.Empty;
}
//Вариант3
string NumbersRec2(int a, int b)
{
    if (a > b)
    {
        return String.Empty;
    }
    else return $"{a} " + NumbersRec2(a + 1, b);
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec1(1, 10));
Console.WriteLine(NumbersRec2(1, 10));
///////////////////////////////////////////////////////////////////////////////////
// Сумма чисел от 1 до N
//Вариант1
int SumFor(int num)
{
    int result = 0;
    for (int i = 0; i <= num; i++) result += i;
    return result;
}
//Вариант2
int SumRec(int num)
{
    if (num == 0) return 0;
    else return num + SumRec(num - 1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
/////////////////////////////////////////////////////////////////////////////////////
// A^n
//Вариант1
int PowFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}
//Вариант2
int PowRec(int a, int n)
{

    return n == 0 ? 1 : PowRec(a, n - 1) * a;
}
Console.WriteLine(PowFor(5, 2));
Console.WriteLine(PowRec(5, 2));

//Вариант3
int PowRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowRecMath(a * a, n / 2);
    else return PowRecMath(a, n - 1) * a;
}
Console.WriteLine(PowRecMath(5, 2));
/////////////////////////////////////////////////////////////////////////
// Собрать все возможные варианты буквенных фраз
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($" {n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("dfgtr",new char[2]);