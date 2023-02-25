// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

using static Random;

int number = ConsoleInput("Введите размер массива :");
int[] arr = RandomArray(number);
PrintArray(arr);
CountPositive(arr);