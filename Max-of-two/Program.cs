Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    Console.WriteLine($"{a} - большее число");
    Console.WriteLine($"{b} - меньшее число");

}

else
{
    Console.WriteLine($"{b} - большее число");
    Console.WriteLine($"{a} - меньшее число");
}