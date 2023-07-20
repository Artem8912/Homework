Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"{a} -  максимальное число ");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine($"{b} - максимальное число ");
    }
    else
    {
        Console.WriteLine($"{c} - максимальное число ");
    }
}
