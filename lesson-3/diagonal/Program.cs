using System;

namespace diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 10;
            int k = 1;
            int[,] array = new int[n,n];

            for(int i = 0; i < n ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = k;
                    k++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                Console.Write("\n");
            }

        }
    }
}
