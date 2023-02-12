Console.Clear();
Console.WriteLine("Input number of day : ");

int number = Convert.ToInt16(Console.ReadLine());

if(number == 6 || number == 7) 
{
    Console.WriteLine("Выходной! Ура!!!");
}
else 
{
    Console.WriteLine("Рабочий день! пора на завод");        
}


