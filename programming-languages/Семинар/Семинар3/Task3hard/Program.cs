// задача 3* - на входе функции натуральное число N,
//  и потом формируется массив из N членов ряда Фибоначчи

uint[] Fibonachi(uint num)
{

    uint[] fibonachi = new uint[num];
    fibonachi[0]=0;
    fibonachi[1]=1;
    for (int index = 2; index <= num - 1; index++)
    {
        fibonachi[index] = fibonachi[index-2] + fibonachi[index-1];
    }
    return fibonachi;
}

Console.Write("Imput N :");
uint number = Convert.ToUInt32(Console.ReadLine());
var fibonachiMass = Fibonachi(number + 1);
// for (int index = 0; index < squareMass.Length - 1; index++)
// {
//     Console.Write($"{squareMass[index]} ");
// }
foreach(uint indexValue in fibonachiMass)
{
     Console.Write($"{indexValue}  ");
}