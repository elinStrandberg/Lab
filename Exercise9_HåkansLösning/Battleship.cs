using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9_HåkansLösning
{
    class Battleship
    {
        int xCoordinate, yCoordinate;
        Random random = new Random();
        char[,] gameBoard = new char[4, 4];

        public void Run()
        {
            while (PlayBattleShip()) ;
        }

        private bool PlayBattleShip()
        {
            bool shipFound = false;
            int xGuess, yGuess;

            InitializeGameBoard();
            DrawGameBoard();

            while (!shipFound)
            {
                Console.WriteLine();
                Console.Write("Ange X-koordinat ([Q] för att avsluta): ");
                xGuess = GetGuess();
                Console.WriteLine(xGuess);
                xGuess--;

                Console.Write("Ange Y-koordinat ([Q] för att avsluta): ");
                yGuess = GetGuess();
                Console.WriteLine(yGuess);
                yGuess--;

                shipFound = (xCoordinate == xGuess) && (yCoordinate == yGuess);

                if (shipFound)
                {
                    gameBoard[xGuess, yGuess] = '*';
                }
                else
                {
                    gameBoard[xGuess, yGuess] = 'o';
                }

                DrawGameBoard();
            }

            Console.Write($"{Environment.NewLine}Grattis! Vill du spela igen?");
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            return (keyInfo.Key == ConsoleKey.J) || (keyInfo.Key == ConsoleKey.Y);
        }

        private int GetGuess()
        {
            ConsoleKeyInfo keyInfo;
            int guess;
            const int Quit = 33;

            do
            {
                keyInfo = Console.ReadKey(true);
                guess = Convert.ToInt32(keyInfo.Key) - 48;
            } while (!((guess >= 1 && guess <= 4) || guess == Quit));

            if (guess == Quit)
            {
                Environment.Exit(0);
            }
            return guess;
        }

        void InitializeGameBoard()
        {
            for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    gameBoard[x, y] = '~';
                }
                xCoordinate = random.Next(0, 4);
                yCoordinate = random.Next(0, 4);
            }
        }

        void DrawGameBoard()
        {
            Console.Clear();

            Console.Write("  |");

            for (int x = 0; x < gameBoard.GetLength(0); x++)
                Console.Write($" {x + 1} |");

            Console.WriteLine();

            for (int y = 0; y < gameBoard.GetLength(1); y++)
            {
                Console.Write($"{y + 1} | ");

                for (int x = 0; x < gameBoard.GetLength(0); x++)
                    Console.Write($"{gameBoard[x, y]}   ");

                Console.WriteLine();
            }

        }
    }
}
