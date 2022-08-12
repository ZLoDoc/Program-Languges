// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Для кокого № элемента создать последовательность Фибоначчи ? :");
int n=Convert.ToInt32(Console.ReadLine());
int[]fib=new int[n+1];
fib[0]=0; fib[1]=1;
Console.Write($"0 1 ");
for(int i=2;i<=n;i++)
{
fib[i]=fib[i-1]+fib[i-2];
Console.Write($"{fib[i]} ");
}

