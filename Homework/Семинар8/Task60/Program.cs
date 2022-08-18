// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] CreateRndDifferentNumbersArray(int num1, int num2, int num3)
{
    int[] RandomNumsArray(int length)
    {
        int[] tempArray = new int[length];
        for (int i = 0; i <= tempArray.Length - 1;)
        {
            int count = 0;
            int temp = new Random().Next(10, 100);
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
        return tempArray;
    }

    int[,,] array = new int[num1, num2, num3];
    int callIndex = 0;
    int[] tempArray = RandomNumsArray(num1 * num2 * num3);

    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            for (int depth = 0; depth < array.GetLength(2); depth++)
            {
                array[rows, columns, depth] = tempArray[callIndex];
                callIndex++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            for (int depth = 0; depth < array.GetLength(2); depth++)
            {
                Console.Write($"{array[rows, columns, depth]}({rows},{columns},{depth}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Количество строк :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов :");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте глубину массива :");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] array = CreateRndDifferentNumbersArray(a, b, c);
PrintArray(array);