// char[] symb = { 'A', 'L', 'I', 'S' };
// int count = 0;
// for (int i = 0; i < symb.Length; i++)
// {

//     for (int j = 0; j < symb.Length; j++)
//     {
//         for (int k = 0; k < symb.Length; k++)
//         {
//             for (int n = 0; n < symb.Length; n++)
//             {
//                 count++;
//                 Console.WriteLine($"{count} {symb[i]}{symb[j]}{symb[k]}{symb[n]}");
//             }
//         }
//     }
// }

// for (double a=-500; a<500;a++)
// {
//     for(double b=-500;b<500;b++)
//     {
//         if (2*a*a*a+3*b*b==8337) Console.WriteLine($" a= {a}, b= {b}");
//     }
// }
int count=0;
for (int i=0; i<=10;i++)
{
Console.WriteLine(++count);
}

int[,]array=new int[,]{{3,4,5,6,7,8},{3,4,5,6,7,8},{3,4,5,6,7,8}};
Console.WriteLine($"memory={array.Length*sizeof(int)}");
