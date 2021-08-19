using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloName();
            //Sum();
            //SumAndMean();
            //WholeNumber();
            //Problem();
            Modulus();
        }

        private static void HelloName()
        {
            Console.WriteLine("Mata in ett namn");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }

        private static void Sum()
        {
            int[] sum = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Mata in ett tal:");
                sum[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summan av talen är {sum[0] + sum[1]}");

            //Console.WriteLine("Mata in ett tal");
            //int tal1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mata in ett tal till");
            //int tal2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Summan av talen är {tal1 + tal2}");
        }

        private static void SumAndMean()
        {
            int[] average = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Mata in ett tal:");
                average[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summan av talen är {average[0] + average[1] + average[2]} och medelvärdet är {(average[0] + average[1] + average[2]) / 3}");

            //Console.WriteLine("Mata in ett tal");
            //int tal1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mata in ett tal till");
            //int tal2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mata in ett tredje tal");
            //int tal3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Summan av talen är {tal1 + tal2 + tal3} och medelvärdet är {(tal1+tal2+tal3)/3}");
        }

        private static void WholeNumber()
        {

            Console.WriteLine("Mata in ett decimaltal");
            double decimaltal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Närmaste heltal för decimaltalet {decimaltal} är {Math.Round(decimaltal)}");
        }

        private static void Problem()
        {
            //Följande kodstycke ger inte rätt utskrift. 
            //Det finns två lösningar på problemet, finn båda.
            //int a = 1;
            //int b = 2;
            //float c = a / b;
            //Console.WriteLine(c);

            //man måste ange antingen att det är en float eller double variabel, annars avrundas svaret till närmsta heltal
            double a = 1;
            double b = 2;
            double c = a / b;
            Console.WriteLine(c);

            int a2 = 1;
            int b2 = 2;
            float c2 = a2 * 1.0f / b2;
            Console.WriteLine(c2);

            int a3 = 1;
            int b3 = 2;
            float c3 = (float)a3 / (float)b3;
            Console.WriteLine(c3);
        }

        private static void Modulus()
        {
            //Vad gör denna operator? Testa med olika värden.
            //int a = 8 % 5; //3
            //Console.WriteLine(a);

            //int b = 8 % 3; //2
            //Console.WriteLine(b);
            //int c = 6 % 1; //0
            //Console.WriteLine(c);
            //int d = 12 % 5; //2
            //Console.WriteLine(d);

            int[] rows = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            

            for (int i = 0; i < rows.Length; i++)
            {
                int modulusResult = rows[i] % 3;

                //if (modulusResult == 0)
                //{
                //    Console.WriteLine("Remainder is 0");
                //}
                //else if (modulusResult == 1)
                //{
                //    Console.WriteLine("Remainder is 1");
                //}
                //else
                //{
                //    Console.WriteLine("Remainder is 2");
                //}

                switch (modulusResult)
                {
                    case 0:
                        Console.WriteLine("Remainder is 0");
                        break;
                    case 1:
                        Console.WriteLine("Remainder is 0");
                        break;
                    case 2:
                        Console.WriteLine("Remainder is 0");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
