using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 x Battleship 4 squares
            //2 x Cruiser 3 squares
            //3 x Destroyers 2 squares
            //4 x Submarines 1 square

            //Battlefield
            char[,] battlefield = new char[10, 10];

            for (int i = 0; i < 10; i++)
            {
                {
                    for (int j = 0; j < 10; j++)
                    {
                        battlefield[i, j] = 'o';
                    }
                }
            }

            Console.Write("Empty Battlefield output\n");

            //Empty Battlefield output
            for (int i = 0; i < 10; i++)
            {
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(battlefield[i, j]);
                    }

                }
                Console.Write("\n");
            }

            //Placement of battleship
            for (int i = 4; i <= 7; i++)
            {
                battlefield[7, i] = 'x';
            }

            //Placement of cruisers

            for (int i = 1; i <= 3; i++)
            {
                battlefield[i, 0] = 'x';
            }

            for (int i = 6; i <= 8; i++)
            {
                battlefield[1, i] = 'x';
            }

            //Placement of destroyers
            for (int i = 7; i <= 8; i++)
            {
                battlefield[4, i] = 'x';
            }

            for (int i = 6; i <= 7; i++)
            {
                battlefield[i, 9] = 'x';
            }

            for (int i = 1; i <= 2; i++)
            {
                battlefield[9, i] = 'x';
            }

            //Placement of submarines

            battlefield[4, 4] = 'x';
            battlefield[2, 4] = 'x';
            battlefield[0, 3] = 'x';
            battlefield[9, 9] = 'x';

            Console.Write("Battlefield output\n");

            //Battlefield output
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(battlefield[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
