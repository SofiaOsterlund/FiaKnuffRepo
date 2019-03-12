using System;

namespace FiaKnuff
{
    class Program
    {
        static Space[,] gameboard = new Space[11, 11];
        static Pawn[] pawns = new Pawn[4];

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
<<<<<<< HEAD
            Console.WriteLine("Hello");
            
=======
            bool won = false;

            do
            {

            } while (!won);
>>>>>>> ccb3ea06b9ff088fb32b86799cc816e08828a4af
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
