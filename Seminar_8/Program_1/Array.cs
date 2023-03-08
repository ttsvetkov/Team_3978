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

    public static void SortInDescendingOrder(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < columns - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k + 1];
                        matrix[i, k + 1] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }

    }
}
