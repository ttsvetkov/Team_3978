public class Pow
    {
        public static void PowN(int N)
        {
            int[] cube = new int[N];

            // Заполняем массив кубами
            for (int i = 1; i <= N; i++)
            {
                cube[i - 1] = i * i * i;
            }

            //Выводим массив в консоль
            for (int j = 0; j < cube.Length; j++)
		        Console.Write(cube[j] + " ");
        }
    }
