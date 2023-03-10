// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов


using System;
using static Input;
using static Array;

int rows = InputNumber("Введите количество строк матрицы");
int columns = InputNumber("Введите количество столбцов матрицы");

int[,] matrix = CreateMatrix(rows, columns);
FillRandomNumbers(matrix);

string output = Print(matrix);
Console.WriteLine(output);

SumInRows(matrix);

