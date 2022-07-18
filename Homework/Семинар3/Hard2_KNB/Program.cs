// Реализовать игру с компьютером "Камень, ножницы , бумага".
// Игра может продолжаться несколько раундов,
// каждый раунд начисляются очки победителю.

int RandomNum()
{
    int i = new Random().Next(1, 4);
    //Console.WriteLine(i);
    if (i == 1) Console.WriteLine("Компьютер выбрал : Камень");
    if (i == 2) Console.WriteLine("Компьютер выбрал : Ножницы");
    if (i == 3) Console.WriteLine("Компьютер выбрал : Бумагу");
    return i;
}
int game = 1;
int meCount = 0;
int compCount = 0;
for (; ; )
{
    Console.WriteLine($"Раунд {game}");
    Console.WriteLine($"Счет: Компьютер: {compCount} Игрок: {meCount}");
    string choise = String.Empty;
    Console.WriteLine("Выберите: Камень, Ножницы или Бумага");
    Console.Write("Я выбираю :");
    choise = Console.ReadLine();
    int figure = 0;
    if (choise.ToLower() == "камень") figure = 1;
    else if (choise.ToLower() == "ножницы") figure = 2;
    else if (choise.ToLower() == "бумага") figure = 3;
    else Console.WriteLine("Это был неправильный выбор");
    int CompChoise = RandomNum();
    if (CompChoise == figure) Console.WriteLine("Ничья");
    else if (CompChoise == 1 && figure == 2)
    {
        Console.WriteLine("Камень компьютера победил мои ножницы");
        compCount++;
    }
    else if (CompChoise == 2 && figure == 1)
    {
        Console.WriteLine("Мой камень победил ножницы компьютера");
        meCount++;
    }
    else if (CompChoise == 2 && figure == 3)
    {
        Console.WriteLine("Ножницы компьютера победили мою бумагу");
        compCount++;
    }
    else if (CompChoise == 3 && figure == 2)
    {
        Console.WriteLine("Мои ножницы победили бумагу компьютера");
        meCount++;
    }
    else if (CompChoise == 1 && figure == 3)
    {
        Console.WriteLine("Моя бумага победила камень компьютера");
        meCount++;
    }
    else if (CompChoise == 3 && figure == 1)
    {
        Console.WriteLine("Бумага компьютера победила мой камень");
        compCount++;
    }
    Console.WriteLine("------------------------------------------------------------");
    game++;
}
