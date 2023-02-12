Console.WriteLine("Введите целое число 1:");
int x = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите целое число 2:");
int y = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите целое число 3:");
int z = Int32.Parse(Console.ReadLine());

if (x > y && x > z)
{
    Console.WriteLine("число 1 больше");
}
else if (x < y && y > z)
{
    Console.WriteLine("число 2 больше");
}
else if (x < z && z > y)
{
    Console.WriteLine("число 3 больше");
}
else
{
    Console.WriteLine("числа равны");
}