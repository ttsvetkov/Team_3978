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

}
