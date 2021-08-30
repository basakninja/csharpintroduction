using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 10000;
            for (int i = 1; i < range; i += 15)
            {
                Console.Write($"{i},{i + 1},Fizz,{i + 3},Buzz,Fizz,{i + 6},{i + 7},Fizz,Buzz,{i + 10},Fizz,{i + 12},{i + 13},FizzBuzz,");
            }




            //public static string FizzBuzzIt(int n) =>
            // (n % 3, n % 5) switch
            // {
            //     (0, 0) => "FizzBuzz",
            //     (0, _) => "Fizz",
            //     (_, 0) => "Buzz",
            //     (_, _) => $"{n}"
            // };

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.Write(" Fizz Buzz,");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.Write(" Fizz,");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.Write(" Buzz,");
            //    }
            //    else
            //    {
            //        Console.Write($" {i},");
            //    }
            //}
        }
    }
}
