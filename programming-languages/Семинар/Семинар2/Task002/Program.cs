// научить робота правильно дописывать окончания к слову программист согласно количесву. На вход подается число, на выходе правильное слово
// если на входе 1, то робот скажет - программист
// если будет 19, то скажет программистов

void End(int NumberOfProgrammer)
{
    int end = (NumberOfProgrammer % 10);
    string letter = " ";
    if (end > 1 && end < 5)
    {
        letter = "а";
    }
    if (end > 4 && end <= 9)
    {
        letter = "ов";
    }
    if (end == 0)
    {
        letter = "ов";
    }
    Console.WriteLine($"WALL-e заехал в комнату и увидел {NumberOfProgrammer} программист{letter} ");
}
//Console.WriteLine($"Введите число :");
//int NumberOfProgrammer = Convert.ToInt32(Console.ReadLine());
int NumberOfProgrammer =new Random().Next(1, 1000);
End(NumberOfProgrammer);

