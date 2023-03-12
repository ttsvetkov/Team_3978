//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static Input;
using static Array;

int rowsA = InputNumber("Введите количество строк матрицы A");
int columnsA = InputNumber("Введите количество столбцов матрицы A");

int rowsB = InputNumber("Введите количество строк матрицы B");
int columnsB = InputNumber("Введите количество столбцов матрицы B");

if (columnsA == rowsB)
{
    int[,] matrixA = CreateMatrix(rowsA, columnsA);
    int[,] matrixB = CreateMatrix(rowsB, columnsB);

    FillRandomNumbers(matrixA);
    FillRandomNumbers(matrixB);

    string output = Print(matrixA);
    Console.WriteLine(output);

    output = Print(matrixB);
    Console.WriteLine(output);

    output = Print(Multiplication(matrixA, matrixB));
    Console.WriteLine(output);
}
else Console.WriteLine("Умножение не возмжожно");