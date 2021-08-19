using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runATM = true;
            decimal totalAmount = 0.0m;
            decimal amount = 0.0m;

            const int numTransactions = 10;
            string[] transactions = new string[numTransactions];
            int transactionCounter = -1;
            while (runATM)
            {
                Console.Clear();

                Console.WriteLine("Vad vill du göra? \n [I] - Insättning \n [U] - Uttag \n [S] - Saldo \n [K] - Kontoutdrag \n [A] - Avsluta");
                Console.WriteLine("--------------------------------------------");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.I:
                        Console.WriteLine("Mata in insättningsbelopp:");
                        amount = decimal.Parse(Console.ReadLine());

                        if (amount > 0.0m)
                        {
                            totalAmount += amount;
                            transactions[++transactionCounter % numTransactions] = $"Insättning {DateTime.Now.ToLongTimeString()}: {amount} SEK";
                        }
                        else
                        {
                            Console.WriteLine("Belopp får inte vara negativt");
                            Console.ReadKey();
                        }
                        break;

                    case ConsoleKey.U:
                        Console.WriteLine("Mata in uttagsbelopp:");
                        amount = decimal.Parse(Console.ReadLine());

                        if ((amount > 0.0m) && (totalAmount - amount >= 0.0m))
                        {
                            totalAmount -= amount;
                            transactions[++transactionCounter % numTransactions] = $"Uttag {DateTime.Now.ToLongTimeString()}: {amount} SEK";
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt uttagsbelopp.");
                            Console.ReadKey();
                        }
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine($"Ditt saldo är: {totalAmount} SEK.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.K:
                        Console.WriteLine("Kontoutdrag:");
                        //Console.WriteLine(transactionCounter);
                        //Console.ReadKey();
                        transactionCounter += numTransactions;
                        //Console.WriteLine(transactionCounter);

                        for (int i = 0; i < numTransactions; i++)
                        {
                            string info = transactions[transactionCounter % numTransactions];
                            //Console.WriteLine(transactionCounter);
                            transactionCounter--;

                            if (info != null)
                            {
                                Console.WriteLine($"{info}");
                            }
                        }
                        Console.ReadKey();
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine("Tack för besöket, välkommen åter. ");
                        runATM = false;
                        break;

                    default:
                        Console.WriteLine("Inget sådant alternativ finns, försök igen.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
