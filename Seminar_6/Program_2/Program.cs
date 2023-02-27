// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using static Input;

static void CheckIntersection(int[] array)
    { // b1 = array[0],
      // b2 = array[1],
      // k1 = array[2],
      // k2 = array[3]
      if(array[2] != array[3])
        {
           double x = (array[1] - array[0]) / (array[2] - array[3]);
           double y = array[2] * x + array[0];
           Console.WriteLine($"Точка пересечения : х = {x}, y = {y}");
        }
          if(array[2] == array[3]) Console.WriteLine("Прямые параллельны");
    }
    
int[] arr = ConsoleInput("Введите b1,b2,k1,k2 через запятую:");
CheckIntersection(arr);
