public class Input
{
    public static int ConsoleInput()
    {
        Console.WriteLine("Введите натуральное число :");
        // вводим строку
        string? input = Console.ReadLine();
        // Проверяем введено ли число
        bool result = int.TryParse(input, out int number);
        
        if(result)
        {
            return number;
        }
        else 
        {
            Console.WriteLine("Введено не число :");
            return -1; 
        }
        
    }
}
