int firstFriendSpeed = 2;
int secondFriendSpeed = 1;
int dogSpeed = 5;
int rasst = 1000;
double distance = rasst;
int count = 1;
int friend = 2;
double time = 0;
double countTime = 0;
for (; dogSpeed < distance; count++)
{

    if (friend == 1)

    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (dogSpeed + secondFriendSpeed);
        friend = 2;
    }
    distance = distance - ((firstFriendSpeed - secondFriendSpeed) * time);
    countTime = countTime + time;
    Console.Write("расстояние ");
    Console.WriteLine(distance);
    Console.Write("время ");
    Console.WriteLine(time);
    Console.WriteLine($"Пробежала {count} раз");
}
Console.Write($"Собака пробежит {rasst} за : ");
Console.WriteLine($"{countTime} секунд");
Console.WriteLine($"Пробежав от человека к человеку {count-1} раз");