using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileLoopToTwenty();
            //WhileLooptoHundred();
            //DoWhileLoopToTwenty();
            DoWhileLooptoHundred();
        }


        private static void WhileLoopToTwenty()
        {
            int counter = 1;
            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        private static void WhileLooptoHundred()
        {
            Console.WriteLine("Mata in det tal som du vill starta uppräkningen från:");
            int enteredNumber = int.Parse(Console.ReadLine());

            while (enteredNumber >= 1 && enteredNumber <= 100)
            {
                Console.WriteLine(enteredNumber++);
            }
        }

        private static void DoWhileLoopToTwenty()
        {
            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 20);
        }

        private static void DoWhileLooptoHundred()
        {
            Console.WriteLine("Mata in det tal som du vill starta uppräkningen från:");
            int enteredNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(enteredNumber++);
            } while (enteredNumber >= 1 && enteredNumber <= 100);
        }

    }
}
