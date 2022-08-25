
int[] tempArray = new int[10];
for (int i = 0; i <= tempArray.Length - 1;i++)
{
    tempArray[i] = new Random().Next(0, 5);
    Console.Write($"{tempArray[i]} \t");
}

Array.Sort(tempArray);
    Console.WriteLine();

// for (int j = 0; j <= tempArray.Length - 1;j++)
// {
//     Console.Write($"{tempArray[j]} \t");
// }
Console.Write(Array.IndexOf(tempArray,3));

