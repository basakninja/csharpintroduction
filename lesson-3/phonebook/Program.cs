using System;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[5,2] {{"Mark Flores","MarkFlores@armyspy.com"},{"Mary Lee","MaryLee@dayrep.com" },{"Christina Colon","ChristinaDColon@rhyta.com" },{ "Sophie Klug", "SophieKlug@jourrapide.com" },{ "Ming Li", "MingLi@rhyta.com" }} ;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{phonebook[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}