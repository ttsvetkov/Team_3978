// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе
using static ArrayGenerate;

int n = ConsoleInput("Введите количество элементов массива :");
int start = ConsoleInput("Введите минимальное значение массива :");
int finish = ConsoleInput("Введите максимальное значение массива :");
int[] arr = Generator(n, start, finish);

Print(arr);

  