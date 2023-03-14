/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int number = Input.InputNumber("Введите число : ");

///Метод вывода натуральных чисел от N до 1:
void PrintNatural(int number)
{
    if (number < 0)
    {
        Console.Write($"{number} не натуральное число");
        return;
    }
    else if (number == 0) return;
    else
    {
        Console.Write($" {number},");
        PrintNatural(number - 1);
    }

}

PrintNatural(number);