using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Array
{
    public static int[,,] CreateArray3D(int a, int b, int c) => new int[a, b, c];

    public static string Print(int[,,] array3D)
    {
        string result = string.Empty;

        int row = array3D.GetLength(0);
        int columns = array3D.GetLength(1);
        int height  = array3D.GetLength(2);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < height; k++)
                {
                    result += $"{array3D[i, j, k]}({i},{j},{k}) ";
                }
            }
            result += "\n";
        }

        return result;
    }

    public static void FillArrayUniqueNumber(ref int[] array_buffer, int min, int max)
    {
        Random random = new Random();

        for (int i = 0; i < array_buffer.Length; i++)
        {
            int number = random.Next(min, max);

            if (array_buffer.Contains(number))
            {
                i--;
            }
            else
            {
                array_buffer[i] = number;
            }
        }
    }
    public static void FillUniqueNumberIn(int[,,] array3D, int[] array_buffer)
{
    
    int row     = array3D.GetLength(0);
    int columns = array3D.GetLength(1);
    int height  = array3D.GetLength(2);
    int count   = 0;

    for (int x = 0; x < row; x++)
    {
        for (int y = 0; y < columns; y++)
        {
            for (int z = 0; z < height; z++)
            {
                array3D[x, y, z] = array_buffer[count];
                count++;
            }
        }
    }
}
}
