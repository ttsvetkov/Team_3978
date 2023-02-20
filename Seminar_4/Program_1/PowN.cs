public class PowN
    {
        public static int ConsoleInput(string msg)
    {
        Console.WriteLine(msg);
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
        public static int Pow(int A, int B)
        {
            int result = A;
            
            for (int i = 1; i < B; i++)
            {
                result *= A; 
            }
            return result;
        }
    }
