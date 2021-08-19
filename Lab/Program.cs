using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            HelloName();
            HelloNameLoop();
            HelloYou();
            Game.Play();

        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static void HelloName()
        {
            Console.WriteLine("Mata in ett namn");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }

        private static void HelloNameLoop()
        {
            Console.WriteLine("Mata in ett namn");
            string name = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello {name}");
            }
        }

        private static void HelloYou()
        {
            Console.WriteLine("Mata in ett namn");
            string name = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (name.ToLower() != "elin")
                {
                    Console.WriteLine($"Hello {name}");
                }
                else
                {
                    Console.WriteLine("Hello you!");
                }
            }
        }
    }

    internal class Game
    {
        static Random randomNumber = new Random();
        static int target = randomNumber.Next(1, 11);
        static int numberOfGuesses = 3;


        public static void Play()
        {
            Console.WriteLine("Can you guess what number between 1 and 10 that I am thinking of? " + target);
            for (int i = 0; i < numberOfGuesses; i++)
            {
                string guessAsString = Console.ReadLine();

                int guess;
                bool parseSuccess = int.TryParse(guessAsString, out guess);

                if (parseSuccess)
                {

                    if (guess == target)
                    {
                        Console.WriteLine($"Correct! The number is {target}.");
                        return;
                        //string answer = Console.ReadLine();
                        //if (answer.ToLower() == "y")
                        //{
                        //    Play();
                        //}
                        //else
                        //{
                        //   return;
                        //}
                    }
                    else
                    {

                        Console.WriteLine($"Wrong number. You have tried {i + 1} out of 3 times.");
                    }

                }
                else
                {
                    Console.WriteLine("This is not a number, please try again");
                    //Play();
                    //return;
                }

            }
            Console.WriteLine($"Game over! The number I was thinking of was {target}.");
            //string answer1 = Console.ReadLine();
            //if (answer1.ToLower() == "Y")
            //{
            //    Play();
            //}
            //else
            //{
            return;
            //}

        }
    }
}
