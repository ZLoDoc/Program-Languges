Console.WriteLine("Введите имя: ");
string Name = Console.ReadLine();
if (Name.ToLower() == "маша")
{
    Console.WriteLine("Ура,это же Маша");
}
else
{
    Console.WriteLine("Привет: ");
    Console.WriteLine(Name);
}