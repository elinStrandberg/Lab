using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //BestTeam();
            //CalculateTemp();
            Problem();
        }

        private static void BestTeam()
        {
            Console.WriteLine("Är MFF Sveriges bästa lag?");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "ja")
            {
                Console.WriteLine("Helt rätt!");
            }

        }
        private static void CalculateTemp()
        {
            Console.WriteLine("Ange temperaturen i Svedala");
            int svedalaTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange temperaturen i Jukkasjärvi");
            int jukkasjärviTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange temperaturen i Visby");
            int visbyTemp = int.Parse(Console.ReadLine());

            if (svedalaTemp < jukkasjärviTemp && svedalaTemp < visbyTemp)
                Console.WriteLine("Det är kallast i Svedala");
            else if (jukkasjärviTemp < svedalaTemp && jukkasjärviTemp < visbyTemp)
                Console.WriteLine("Det är kallast i Jukkasjärvi");
            else if (visbyTemp < jukkasjärviTemp && visbyTemp < svedalaTemp)
                Console.WriteLine("Det är kallast i Visby");

            else if (svedalaTemp < jukkasjärviTemp && svedalaTemp > visbyTemp)
                Console.WriteLine("Det är kallast i Visby");
            else if (jukkasjärviTemp < svedalaTemp && jukkasjärviTemp > visbyTemp)
                Console.WriteLine("Det är kallast i Visby");

            else if (visbyTemp < svedalaTemp && visbyTemp > jukkasjärviTemp)
                Console.WriteLine("Det är kallast i Jukkasjärvi");
            else if (svedalaTemp < visbyTemp && svedalaTemp > jukkasjärviTemp)
                Console.WriteLine("Det är kallast i Jukkasjärvi");

            else if (jukkasjärviTemp < visbyTemp && jukkasjärviTemp > svedalaTemp)
                Console.WriteLine("Det är kallast i Svedala");
            else if (visbyTemp < jukkasjärviTemp && visbyTemp > svedalaTemp)
                Console.WriteLine("Det är kallast i Svedala");

            Console.WriteLine($"Medeltemperaturen är {(svedalaTemp+jukkasjärviTemp+visbyTemp)/3}");

        }
        private static void Problem()
        {
            //Något stämmer inte med följande kod, vad?

            int var = 10;
            if (var == 10)
            {
                Console.WriteLine("Den är tio");
            }

        }
    }
}
