// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;
using static Input;
using static Array;

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");

double[,] matrix = CreateMatrix(rows, columns);
FillRandomFloatNumbers(matrix);

string output = Print(matrix);
Console.WriteLine(output);
