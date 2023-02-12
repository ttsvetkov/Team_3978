Console.Clear();
Console.WriteLine("Input number : ");
var number = Console.ReadLine();
analize(number);

void analize(string s)
{
    if(s.Length < 3) 
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else 
    {
        Console.WriteLine($"Третья цифра : {s[2]}");        
    }
}
