// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using static Array;

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = Input.InputNumber("Введите X: ");
int y = Input.InputNumber("Введите Y: ");
int z = Input.InputNumber("Введите Z: ");
Console.WriteLine();

int[] array_buffer = new int[x * y * z];
FillArrayUniqueNumber(ref array_buffer, 10, 100);

int[,,] array3D = CreateArray3D(x, y, z);
FillUniqueNumberIn(array3D, array_buffer);
string output = Print(array3D);

System.Console.WriteLine(output);


