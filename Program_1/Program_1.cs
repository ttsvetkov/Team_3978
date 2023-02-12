Console.WriteLine("Введите целое число 1 :");
var value1 = Console.ReadLine();
int x = Int32.Parse(value1);

Console.WriteLine("Введите целое число 2 :");
var value2 = Console.ReadLine();
int y = Int32.Parse(value2);

if (x > y)
{
    Console.WriteLine("число 1 больше");
}
else if (x == y)
{
    Console.WriteLine("числа равны");
}
else 
{
    Console.WriteLine("число 2 больше");
}