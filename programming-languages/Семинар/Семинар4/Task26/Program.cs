// Задача 26: Напишите программу, которая принимает на вход
//число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int s = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (s == 0) count = 1;
while(s != 0)

    {
        s = s / 10;
        count = count + 1;
        
    }   
Console.Write(count);

// Console.WriteLine("Введите число");
// int s = Convert.ToInt32(Console.ReadLine());
// int num (int s)
//     {
//     int count = 0;
//     if (s == 0) count = 1;
//     while(s != 0)

//         {
//             s = s / 10;
//             count = count + 1;
            
//         }
//     return count; 
//     }       
// Console.Write(num(s));



