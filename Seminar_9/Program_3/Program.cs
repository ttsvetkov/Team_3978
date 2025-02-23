﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.    m = 2, n = 3 -> A(m,n) = 9


int m = Input.InputNumber("Введите m: ");
int n = Input.InputNumber("Введите n: ");

int functionAkkerman = A(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

static int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}