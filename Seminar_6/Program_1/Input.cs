using System;

public class Input
    {
        public static int[] ConsoleInput()
    {
        string buffer = String.Empty; //буфер
        
        List<int> Data = new List<int>(); // Массив списочного типа 
        
        Console.WriteLine("Введите числа через запятую :");
        // получаем строку
        string inputX = Console.ReadLine();

        for(int i = 0; i < inputX.Length; i++)
        {
            if(inputX[i] == ',') //дошли до следующего числа
            {
                Data.Add(CheckNumbers(buffer));//сохраняем предыдущее через проверку
                buffer = String.Empty;  // очищаем буфер
            }
            if(inputX[i] != ',')
            {               
                buffer += inputX[i]; //записываем числа в буферную строку(конкатенация символов) 
            }
        }
        Data.Add(CheckNumbers(buffer)); //запись последнего элемента в массив
        PrintArray(Data.ToArray()); //вывод массива на экран

        return Data.ToArray();
    }
    //Функция проверки введенного символа => должно быть число, иначе вернёт -1
    public static int CheckNumbers(string number)
    {
        if(int.TryParse(number, out int number2))
            {
                return number2;
            }
        else 
            {
                Console.WriteLine("Введено не число!!!");
                return -1;
            }
    }
    //Функция вывода массива чисел в терминал
    public static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]},");
                
            }
            Console.Write("]");
        }
    // Функция подсчета положительных чисел в массиве чисел
    public static void CountPositive(int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0) count++;
        }
        Console.Write($" => {count},");
    }
    }
