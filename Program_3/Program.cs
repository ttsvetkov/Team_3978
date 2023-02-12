Console.WriteLine("Введите целое число 1:");
int x = Int32.Parse(Console.ReadLine());

x = x % 2;

if (x == 0 )
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число не четное");
}