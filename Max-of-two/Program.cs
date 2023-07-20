int a = ConvertToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = ConvertToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");

if (a >b) 
{
    Console.Write($"{a} - большее число");
    Console.Write($"{b} - меньшее число");  
    
}

else 
{
   Console.Write($"{b} - большее число");
   Console.Write($"{a} - меньшее число"); 
}