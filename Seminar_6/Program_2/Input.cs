using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Input
    {
        public static int[] ConsoleInput(string msg)
        {
        string buffer = String.Empty; //буфер
        List<int> Data = new List<int>(); // Массив списочного типа 

        Console.WriteLine(msg);
        string inputX = Console.ReadLine();// получаем строку

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
        //PrintArray(Data.ToArray()); //вывод массива на экран

        return Data.ToArray();
        }
    //Функция проверки введенного символа => должно быть число, иначе вернёт -1
        static int CheckNumbers(string number)
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
        
    }
