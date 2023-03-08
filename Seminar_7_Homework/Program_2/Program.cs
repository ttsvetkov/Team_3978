// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static Input;
using static Array;

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");

double[,] matrix = CreateMatrix(rows, columns);
FillRandomFloatNumbers(matrix);

string output = Print(matrix);
Console.WriteLine(output);

FindElementIn(matrix);
