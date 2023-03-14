// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


int numberM = Input.InputNumber("Введите начальное число M : ");
int numberN = Input.InputNumber("Введите конечное число N : ");

void Sum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма : {sum}");
        return;
    }
    else
    {
        sum = sum + numberM;
        Sum((numberM + 1), numberN, sum);
    }
}

Sum(numberM, numberN, 0);