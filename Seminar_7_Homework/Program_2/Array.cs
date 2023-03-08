using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Array
{
    public static double[,] CreateMatrix(int a, int b) => new double[a, b];

    public static void FillRandomFloatNumbers(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Math.Round((new Random().NextDouble() * 2 - 1) * 10, 1);
            }
        }
    }
    public static string Print(double[,] matrix)
    {
        string result = string.Empty;

        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result += $"{matrix[i, j],5} ";
            }
            result += "\n";
        }

        return result;
    }
    public static void FindElementIn(double[,] matrix)
    {
        int row    = Input.InputNumber("Введите индекс строки  :");
        int column = Input.InputNumber("Введите индекс столбца :");

        if (row < 0 | row > matrix.GetLength(0) - 1 | column < 0 | column > matrix.GetLength(1) - 1)
        {
            Console.WriteLine("Элемент не существует");
        }
        else
        {
            Console.WriteLine("Значение элемента массива = {0}", matrix[row, column]);
        }
        Console.ReadLine();
    }
}
