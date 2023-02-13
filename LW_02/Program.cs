//Дан двумерный массив целых чисел. Сформировать одномерный массив, каждый элемент которого равен количеству 
//отрицательных элементов в соответствующей строке двумерного массива, кратных 3 или 7.

using System;

namespace LW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите способ задания массива (0 - рандом, 1 - руками):");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размеры массива через Enter: ");
            int xSize = int.Parse(Console.ReadLine());
            int ySize = int.Parse(Console.ReadLine());
            int[,] mas = new int[ySize, xSize];
            int[] mas1 = new int[ySize];
            Random rand = new Random();
            for (int i = 0; i < ySize; i++)
            {
                for (int y = 0; y<xSize; y++)
                {
                    switch (a)
                    {
                        case 0:
                            mas[i, y] = (int)rand.Next(-1000, 1000);
                            if (mas[i, y]<0 && (mas[i, y] % 3 == 0 || mas[i, y] % 7 == 0))
                            {
                                mas1[i]++;
                                Console.WriteLine(mas1[i]);
                            }
                            continue;
                        case 1:
                            Console.WriteLine("Введите число: ");
                            mas[i, y] = int.Parse(Console.ReadLine());
                            if (mas[i, y]<0 && (mas[i, y]%3==0 || mas[i, y] % 7 == 0))
                            {
                                mas1[i]++;
                            }
                            continue;
                    }
                    
                }
            }
            for (int i = 0; i<mas1.Length; i++)
            {
                Console.Write(mas1[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
