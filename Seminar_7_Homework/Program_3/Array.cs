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
                matrix[i, j] = new Random().Next(1,10);
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
    
    public static void ArithmeticMeanColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        double sum = 0;

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                sum += matrix[j, i]; 
            } 
            sum = Math.Round(sum / rows, 1);
            System.Console.WriteLine($"ArithmeticMeanColumns № {i+1} = {sum} ");
            sum = 0;
        }
        
    }
}
