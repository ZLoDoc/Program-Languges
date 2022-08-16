Console.Write("Введите Ваше имя :");
string name = Console.ReadLine();

Console.Write("Введите минимальный попрог :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный попрог :");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный ход :");
int con = Convert.ToInt32(Console.ReadLine());
int count=0;
for (;;)
{
    count++;
    Console.Write($"{count} раунд!!!\n");
    Console.Write($"Сделай ход от 0 до {con} :");
    int goHum = Convert.ToInt32(Console.ReadLine());
    int goComp = new Random().Next(0,con);
   
    if (goHum>con || goHum<0) 
    {
        Console.Write($"Ваш ход не в диапазоне от 0 до {con} :\n");
        continue;
    }

    if (max>0)
    {
        Console.Write($" Ваш ход: {max} - {goHum} = {max-goHum}\n");
        max-=goHum;
        if(max<=0)
        {
        Console.Write($"Ты выиграл\n");
        break;
        }

        Console.Write($" Ход Компьютера: {max} - {goComp} = {max-goComp}\n");
        max-=goComp;
        if(max<=0)
        {
        Console.Write($"Компьютер выиграл\n");
        break;
        }
        //if(max<=0)Console.Write($"Ты выиграл\n");
        //Console.Write($"{max}\n");
    }

}
