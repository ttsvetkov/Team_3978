public class GetCoor
{
    public static string[] ConsoleInputX()
    {
         string[] X = new string[3];
        

        int flagX = 0; // флаг для парсинга строки координат X
        
        Console.WriteLine("Введите координаты X через запятую:");
        // вводим строку
        string inputX = Console.ReadLine();

        for(int i = 0; i < inputX.Length; i++)
        {
            if(inputX[i] == ',') flagX++;
            if(inputX[i] != ',' && flagX == 0) X[flagX] += inputX[i];
            if(inputX[i] != ',' && flagX == 1) X[flagX] += inputX[i];
            if(inputX[i] != ',' && flagX == 2) X[flagX] += inputX[i];
            
        }
        Console.WriteLine($"координаты Y : {X[0]} : {X[1]} : {X[2]}");
        return X;
    }

     public static string[] ConsoleInputY()
    {
        //string x2 = String.Empty, y2 = String.Empty, z2 = String.Empty;
        
        string[] Y = new string[3];

        int flagY = 0; // флаг для парсинга строки координат Y

        Console.WriteLine("Введите координаты Y через запятую:");
        // вводим строку
        string inputY = Console.ReadLine();

        for(int i = 0; i < inputY.Length; i++)
        {
            if(inputY[i] == ',') flagY++;
            if(inputY[i] != ',' && flagY == 0) Y[flagY] += inputY[i];
            if(inputY[i] != ',' && flagY == 1) Y[flagY] += inputY[i];
            if(inputY[i] != ',' && flagY == 2) Y[flagY] += inputY[i];
            
        }
        Console.WriteLine($"координаты Y : {Y[0]} : {Y[1]} : {Y[2]}");
        return Y;
    }
}
