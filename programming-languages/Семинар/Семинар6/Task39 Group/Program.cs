void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,100);
    }

PrintArray(massive);
Console.WriteLine();

    int value=0;
   
    for(int i = 0; i < massive.Length/2; i++)
    {
        value=massive[i];
        massive[i]=massive[massive.Length-1-i];
        massive[massive.Length-1-i] =value;
    }

PrintArray(massive);
