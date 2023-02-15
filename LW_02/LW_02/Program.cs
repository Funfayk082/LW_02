//Дан двумерный массив целых чисел. Сформировать одномерный массив, каждый элемент которого равен количеству 
//отрицательных элементов в соответствующей строке двумерного массива, кратных 3 или 7.

using System;

namespace LW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Выберите способ задания массива (0 - рандом, 1 - руками):");
            bool trying = int.TryParse(Console.ReadLine(), out a);
            while (!trying)
            {
                Console.WriteLine("Введено не число. Повторите попытку, введите 0 или 1: ");
                trying = int.TryParse(Console.ReadLine(), out a);
            }
            while (a != 0 && a != 1)
            {
                Console.WriteLine("Введите 0 или 1!", a);
                int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("Введите размеры массива через Enter: ");
            bool trying1 = int.TryParse(Console.ReadLine(), out int xSize);
            bool trying2 = int.TryParse(Console.ReadLine(), out int ySize);
            while (!trying1 || !trying2)
            {
                Console.WriteLine("Введены не числа. Повторите попытку, введите разверы массива через Enter: ");
                trying1 = int.TryParse(Console.ReadLine(), out xSize);
                trying2 = int.TryParse(Console.ReadLine(), out ySize);
            }
            int[,] mas = new int[ySize, xSize];
            int[] mas1 = new int[ySize];
            Random rand = new Random();
            for (int i = 0; i < ySize; i++)
            {
                for (int y = 0; y < xSize; y++)
                {
                    switch (a)
                    {
                        case 0:
                            mas[i, y] = (int)rand.Next(-1000, 1000);
                            if (mas[i, y] < 0 && (mas[i, y] % 3 == 0 || mas[i, y] % 7 == 0))
                            {
                                mas1[i]++;
                                Console.WriteLine(mas1[i]);
                            }
                            continue;
                        case 1:
                            Console.WriteLine("Введите число: ");
                            bool trying3 = int.TryParse(Console.ReadLine(), out int m);
                            while (!trying3)
                            {
                                Console.WriteLine("Введено не число. Повторите попытку:  ");
                                int.TryParse(Console.ReadLine(), out m);
                            }
                            mas[i, y] = m;
                            if (mas[i, y] < 0 && (mas[i, y] % 3 == 0 || mas[i, y] % 7 == 0))
                            {
                                mas1[i]++;
                            }
                            continue;
                    }

                }
            }
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Console.ReadLine();
        }
    }
}