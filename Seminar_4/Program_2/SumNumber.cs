public class SumNumber
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
                //Console.WriteLine(number);
                return number;
            }
            else 
            {
                Console.WriteLine("Введено не число :");
                return -1; 
            }
            
        }

        public static int Sum(int number)
        {
            int res = 0;
            while(number > 0)
            {
                res += number % 10;
                number = number / 10;
            }
            return res;
        } 
    }