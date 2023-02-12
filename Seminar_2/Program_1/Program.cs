// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите трехзначное число :");

int x = Convert.ToInt32(Console.ReadLine());
int y = -1;

if( x > 99 && x < 1000)
{
   y = (x / 10) % 10;
   Console.WriteLine ($"Вторая цифра : {y}"); 
}
else Console.WriteLine("Error input");
