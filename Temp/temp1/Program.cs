
int[] tempArray = new int[5];
for (int i = 0; i <= tempArray.Length - 1;)
{
    int count = 0;
    int temp = new Random().Next(10, 19);
    for (int j = 0; j <= tempArray.Length - 1; j++)
    {
        if (tempArray[j] == temp) count++;
    }
    if (count == 0)
    {
        tempArray[i] = temp;
        i++;
        count = 0;
    }
}
for (int n = 0; n <= tempArray.Length - 1; n++) Console.WriteLine(tempArray[n]);


