using System;

namespace Pract9BurKla
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                int[,] m = new int[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        m[i, j] = 1 - (i + j) % 2;
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            //2
            {
                int[,] m = new int[10, 10];
                Random rnd = new Random();
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        m[i, j] = rnd.Next(1, 99);
                        Console.Write("\t" + m[i, j]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        sum += m[i, j];
                    }
                    Console.WriteLine($"Сумма {i+1} строки = " + sum);
                    sum = 0;
                }
            }
        }
    }
}
