﻿Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.Write($"{a} ");
        a++;
    }
    else
    {
        a++;
    }

}
Console.Write(" - чётные числа");
