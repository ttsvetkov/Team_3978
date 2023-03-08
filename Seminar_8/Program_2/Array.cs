using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Array
{
    public static int[,] CreateMatrix(int a, int b) => new int[a, b];

    public static void FillRandomNumbers(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = new Random().Next(1, 10);
            }
        }
    }
    public static string Print(int[,] matrix)
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

    public static void SumInRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int sum = 0, min_sum = 0, index_min_sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j];
            }

            if (i == 0) min_sum = sum;
            if (sum < min_sum)
            {
                min_sum = sum;
                index_min_sum = i;
            }
            sum = 0;
        }
        System.Console.WriteLine($"Min_Sum № {index_min_sum} = {min_sum} ");
    }
}
