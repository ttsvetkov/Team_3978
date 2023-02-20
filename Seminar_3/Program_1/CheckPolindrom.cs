 public class CheckPolindrom
    {
       public static int CheckPol(string number)
       {
            int len = number.Length - 1; // Максимальное значение индекса элементов строки 
            bool flag = true; // флаг 
            for (int i = 0; i <= len - i; i++)
            {
                if(number[i] != number[len - i]) // Сверяем начало и конец строки
                {
                    flag = false;
                    Console.Write("Не является палиндромом");
                    return -1;
                }
            }
            if(flag) 
            {
                Console.Write("Является палиндромом");
                return 1;
            }
            return 0;
       } 
    }
