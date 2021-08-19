using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArrayOfNames = new string[5];

            //PrintNamesInReverse(myArrayOfNames);
            //ChangeNameInArray(myArrayOfNames);
            WeatherStation();

        }

        private static string[] PrintNamesInReverse(string[] myArray)
        {
            

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Skriv namn {i + 1}:");
                myArray[i] = Console.ReadLine();
            }

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i + 1}. {myArray[i]}");
            }

            return myArray;
        }

        private static string[] ChangeNameInArray(string[] myArray)
        {
            //const int numOfElements = 5;

            Console.WriteLine("Ange siffran för det namn du vill uppdatera:");
            int index = int.Parse(Console.ReadLine()) -1;

            Console.WriteLine($"Ange det nya namnet för {myArray[index]}:");
            string newName = Console.ReadLine();

            for (int i = 0; i < myArray.Length -1; i++)
            {
                if (i == index)
                {
                    myArray[i] = newName;
                    //Console.WriteLine($"{i + 1}. {myArray[i]}");
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {myArray[i]}");
            }

            return myArray;
        }

        private static void WeatherStation()
        {
            Console.WriteLine("VÄDERSTATION POLARCIRKELN");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.WriteLine("Hur många temperaturmätningar har gjorts? ");
            int amountOfMeasureMents = int.Parse(Console.ReadLine());

            double[] measurements = new double[amountOfMeasureMents];

            for (int i = 0; i < measurements.Length; i++)
            {
                Console.WriteLine($"Skriv in temperatur för mätning {i + 1}:");
                measurements[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < measurements.Length; i++)
            {
                Console.WriteLine($"{i+1}: {measurements[i]}");
            }

            double averageTemp = 0.0;

            for (int i = 0; i < measurements.Length; i++)
            {
                averageTemp += measurements[i];
            }

            Console.WriteLine($"Medeltemperaturen för {amountOfMeasureMents} mätningar är: {averageTemp /= measurements.Length }");
        }
    }
}
