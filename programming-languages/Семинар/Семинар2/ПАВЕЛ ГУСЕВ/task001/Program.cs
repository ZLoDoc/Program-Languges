int FindBidderDigital(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;
    if (ed > dec) max = ed;
    else max = dec;
    return max;
}

int number = new Random().Next(10,100);
int digit = FindBidderDigital(number);
Console.WriteLine($"Bigger digit of {number} is {digit} ");
