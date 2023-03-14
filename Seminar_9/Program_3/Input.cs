using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Input
{
    public static int InputNumber(string msg)
    {
        bool flag = false;
        int value = 0;
        while (!flag)
        {
            Console.Write(msg + " ");
            flag = int.TryParse(Console.ReadLine(), out value);
            if(value < 0) flag = false;
        }
        return value;
    }

}
