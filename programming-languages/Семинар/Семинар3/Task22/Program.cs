// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareTable(int num)
{

    int[] square=new int[num];
    for (int index = 0; index <= num; index++)
    {
        square[index]=index*index;
        //Console.WriteLine(index);
        Console.WriteLine(square[index]);

    }

}

Console.Write("Imput N :");
int number=Convert.ToInt32(Console.ReadLine());
SquareTable(number+1);