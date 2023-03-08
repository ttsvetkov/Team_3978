// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static Input;
using static Array;

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");

int[,] matrix = CreateMatrix(rows, columns);
FillRandomNumbers(matrix);

string output = Print(matrix);
Console.WriteLine(output);

ArithmeticMeanColumns(matrix);

