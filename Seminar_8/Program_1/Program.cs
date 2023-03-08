// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массиваon

using System;
using static Input;
using static Array;

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");

int[,] matrix = CreateMatrix(rows, columns);
FillRandomNumbers(matrix);

string output = Print(matrix);
Console.WriteLine(output);

SortInDescendingOrder(matrix);

output = Print(matrix);
Console.WriteLine(output);