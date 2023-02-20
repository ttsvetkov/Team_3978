public class ArrayGenerate
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
        public static int[] Generator(int length, int min, int max)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max);                
            }
            
            return array;
        }

        public static void Print(int[] array)
        {
            Console.Write("[");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
                
            }
            Console.Write("]");
        }
    }