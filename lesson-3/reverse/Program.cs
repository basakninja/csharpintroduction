using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str);
            for (int i = str.Length - 1 ; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
