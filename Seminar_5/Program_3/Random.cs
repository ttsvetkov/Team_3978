public class Random
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
        public static int[] RandomArray(int size)
        {
            int[] array = new int[size];
            System.Random rnd = new System.Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,100);
            }
            return array;
        }

        public static void FindDiff(int[] array)
        {   
            int min = array[0], max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max) max = array[i];
                if(array[i] < min) min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Разница : {max - min}");
        }

        public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]},");
                
            }
            Console.Write("]");
        }
    }
