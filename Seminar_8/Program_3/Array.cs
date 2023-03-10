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

    public static int[,] Multiplication(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);

        int rowsB = matrixB.GetLength(0);
        int columnsB = matrixB.GetLength(1);

        int[,] matrixC = Array.CreateMatrix(rowsA,columnsB);

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < columnsA; k++)
                {
                    matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                }
            }
        }
        return matrixC;        
    }
}
