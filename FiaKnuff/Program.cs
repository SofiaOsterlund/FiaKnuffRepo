using System;

namespace FiaKnuff
{
    class Program
    {
        static Space[,] gameboard = new Space[11, 11];

        static void Main(string[] args)
        {
            CreateGame();
            PlayGame();
            End();
        }

        private static void End()
        {
            throw new NotImplementedException();
        }

        private static void PlayGame()
        {
            PrintGame();
            Console.ReadKey(true);
        }

        private static void PrintGame()
        {
            for (int i = 0; i < gameboard.GetLength(0); i++)
            {
                for (int j = 0; j < gameboard.GetLength(1); j++)
                {
                    if (gameboard[i, j] != null)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }


                }
                Console.WriteLine();


            }
        }

        private static void CreateGame()
        {
            for (int i = 0; i < gameboard.GetLength(0); i++)
            {
                for (int j = 0; j < gameboard.GetLength(1); j++)
                {
                    if (i > 3 && i < 7)
                    {
                        gameboard[i, j] = new Space();
                    }
                    if (j > 3 && j < 7)
                    {
                        gameboard[i, j] = new Space();
                    }
                }


            }
        }
    }
}
