int[] arr = { 5, 6, 7, 8, 4, 3, 6, 7, 5 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine("");
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        int temporary = array[i];
        array[i] = array[minPosition];
    }
}

PrintArray(arr);
