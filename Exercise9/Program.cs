using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 4;
            const int y = 4;

            string[,] battleShipGameField = new string[x, y];

            InitBattleshipGame(battleShipGameField, "~ ");
            PrintbattleShipGame(battleShipGameField);
            PlayBattleshipGame(battleShipGameField);
        }

        private static void InitBattleshipGame(string[,] battleShipGameField, string character)
        {
            int x_dim_len = battleShipGameField.GetLength(0);
            int y_dim_len = battleShipGameField.GetLength(1);

            for (int y = 0; y < y_dim_len; y++)
            {
                for (int x = 0; x < x_dim_len; x++)
                {
                    battleShipGameField[x, y] = character;
                }
            }
        }

        private static void PrintbattleShipGame(string[,] battleShipGameField)
        {
            Console.Clear();

            int x_dim_len = battleShipGameField.GetLength(0);
            int y_dim_len = battleShipGameField.GetLength(1);

            for (int y = 0; y < y_dim_len; y++)
            {
                for (int x = 0; x < x_dim_len; x++)
                {
                    Console.Write(battleShipGameField[x, y]);
                }
                Console.WriteLine();
            }
        }

        private static void PlayBattleshipGame(string[,] battleShipGameField)
        {
            Random random = new Random();

            int xCoordinate = random.Next(1, 4 + 1);
            int yCoordinate = random.Next(1, 4 + 1);
            bool hit = false;

            Console.WriteLine("Welcome to the Battleship.");

            while (hit == false)
            {
                int xGuess = 0;
                int yGuess = 0;

                Console.WriteLine("Enter coordinate X:");
                xGuess = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter coordinate Y:");
                yGuess = int.Parse(Console.ReadLine());

                if (xCoordinate == xGuess && yCoordinate == yGuess)
                {
                    hit = true;
                    Console.WriteLine("It's a hit!");
                    xGuess = xCoordinate;
                    yGuess = yCoordinate;
                    string hitCharacter = "*";

                    battleShipGameField[xGuess, yGuess] = hitCharacter;
                    //Console.Clear();
                }
                else
                {
                    Console.WriteLine("It's a miss!");

                    xGuess = xCoordinate;
                    yGuess = yCoordinate;
                    string missCharacter = "x";

                    battleShipGameField[xGuess,yGuess] = missCharacter;

                    //Console.Clear();

                }

            }

        }
    }
}
